# CSharp-Ransomware

## Proje Hakkında
**CSharp-Ransomware**, C# kullanılarak geliştirilmiş bir fidye yazılımıdır. Program, belirli dosya türlerini AES şifreleme algoritmasını kullanarak şifreler ve belirlenen süre içinde ödeme yapılmazsa erişimi engeller.


---

##  Özellikler
- **AES Şifreleme**: Dosyaları güçlü AES algoritmasıyla şifreler.
- **Dosya Hedefleme**: `.txt`, `.pdf`, `.png`, `.jpg` gibi belirli dosya türlerini hedef alır.
- **Geri Sayım Mekanizması**: Kullanıcıya belirli bir süre tanır.
- **Duvar Kağıdı Değiştirme**: Kullanıcının masaüstü duvar kağıdını değiştirir.
- **Ödeme Yönlendirmesi**: Kullanıcıyı belirlenen bir BTC ödeme adresine yönlendirir.

---

##  Klasör Yapısı
```
CSharp-Ransomware/
│── FileEncryptionApp/
│   │── bin/          # Derlenmiş dosyalar (hariç tutulmuştur)
│   │── obj/          # Derleme sırasında oluşan geçici dosyalar (hariç tutulmuştur)
│   │── Images/       # Kullanılan resimler (lock, btc, duvar kağıdı vb.)
│   │── Program.cs    # Ana uygulama mantığı
│   │── Form1.cs      # Kullanıcı arayüzü bileşenleri
│   │── Encryption.cs # Şifreleme ve şifre çözme algoritmaları
│   │── .gitignore    # Gereksiz dosyaları hariç tutan Git yapılandırma dosyası
│   └── README.md     # Proje açıklama dosyası
```

---

##  Kurulum & Kullanım
1. **Projeyi klonla:**
   ```bash
   git clone https://github.com/furkansarisin/CSharp-Ransomware.git
   cd CSharp-Ransomware/FileEncryptionApp
   ```

2. **Visual Studio ile aç ve derle.**
3. **Uygulamayı çalıştır.**
4. **Şifreleme** işlemi otomatik olarak başlayacaktır.

---

##  Şifreleme ve Şifre Çözme
- **AES Şifreleme** işlemi `EncryptFile()` fonksiyonu ile gerçekleştirilir.
- **Şifre çözme** işlemi `DecryptFile()` fonksiyonu ile yapılır.
- **Şifrelenmiş dosyaları kurtarmak için doğru şifreyi girmeniz gerekir.**

---

##  Kullanılan Kaynaklar
- **C# WinForms**: Kullanıcı arayüzü geliştirme
- **System.Security.Cryptography**: AES şifreleme algoritması
- **System.IO**: Dosya işlemleri
- **System.Windows.Forms**: UI ve Clipboard işlemleri

---

## Yasal Uyarı
Bu yazılım yalnızca **bilgi güvenliği araştırmaları ve eğitim amaçlıdır**.  
Yasa dışı kullanım kesinlikle yasaktır.  
Geliştirici, bu yazılımın kötüye kullanılması durumunda hiçbir sorumluluk kabul etmez.  
