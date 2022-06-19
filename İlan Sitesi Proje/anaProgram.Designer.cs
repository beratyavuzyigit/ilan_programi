namespace İlan_Sitesi_Proje
{
    partial class anaProgram
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaProgram));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.hata_label = new System.Windows.Forms.Label();
            this.girisPanel = new System.Windows.Forms.Panel();
            this.beniHatirla = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uyePanel = new System.Windows.Forms.Panel();
            this.adminButton = new System.Windows.Forms.Button();
            this.merhaba_label = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.islemPanel = new System.Windows.Forms.Panel();
            this.girisPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uyePanel.SuspendLayout();
            this.islemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(197, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "İŞLEMLER";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(110, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "İlan Ver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(110, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "İlanlara Gözat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(99, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 49);
            this.label2.TabIndex = 3;
            this.label2.Text = "ÜYELİK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mail
            // 
            this.mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail.Location = new System.Drawing.Point(96, 128);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(358, 43);
            this.mail.TabIndex = 15;
            // 
            // sifre
            // 
            this.sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifre.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Location = new System.Drawing.Point(96, 182);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(358, 43);
            this.sifre.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(251, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 48);
            this.button3.TabIndex = 18;
            this.button3.Text = "Kayıt Ol";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(42, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 48);
            this.button4.TabIndex = 17;
            this.button4.Text = "Giriş Yap";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // hata_label
            // 
            this.hata_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata_label.ForeColor = System.Drawing.Color.Red;
            this.hata_label.Location = new System.Drawing.Point(38, 339);
            this.hata_label.Name = "hata_label";
            this.hata_label.Size = new System.Drawing.Size(416, 46);
            this.hata_label.TabIndex = 19;
            this.hata_label.Text = "hata_label";
            this.hata_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hata_label.Visible = false;
            // 
            // girisPanel
            // 
            this.girisPanel.Controls.Add(this.beniHatirla);
            this.girisPanel.Controls.Add(this.pictureBox2);
            this.girisPanel.Controls.Add(this.pictureBox1);
            this.girisPanel.Controls.Add(this.label2);
            this.girisPanel.Controls.Add(this.hata_label);
            this.girisPanel.Controls.Add(this.button3);
            this.girisPanel.Controls.Add(this.button4);
            this.girisPanel.Controls.Add(this.mail);
            this.girisPanel.Controls.Add(this.sifre);
            this.girisPanel.Location = new System.Drawing.Point(12, 12);
            this.girisPanel.Name = "girisPanel";
            this.girisPanel.Size = new System.Drawing.Size(515, 406);
            this.girisPanel.TabIndex = 20;
            // 
            // beniHatirla
            // 
            this.beniHatirla.AutoSize = true;
            this.beniHatirla.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.beniHatirla.Location = new System.Drawing.Point(42, 285);
            this.beniHatirla.Name = "beniHatirla";
            this.beniHatirla.Size = new System.Drawing.Size(182, 42);
            this.beniHatirla.TabIndex = 22;
            this.beniHatirla.Text = "Beni Hatırla";
            this.beniHatirla.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::İlan_Sitesi_Proje.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(42, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::İlan_Sitesi_Proje.Properties.Resources.mail;
            this.pictureBox1.Location = new System.Drawing.Point(42, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // uyePanel
            // 
            this.uyePanel.Controls.Add(this.adminButton);
            this.uyePanel.Controls.Add(this.merhaba_label);
            this.uyePanel.Controls.Add(this.button6);
            this.uyePanel.Controls.Add(this.button5);
            this.uyePanel.Location = new System.Drawing.Point(12, 12);
            this.uyePanel.Name = "uyePanel";
            this.uyePanel.Size = new System.Drawing.Size(515, 406);
            this.uyePanel.TabIndex = 22;
            this.uyePanel.Visible = false;
            // 
            // adminButton
            // 
            this.adminButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.adminButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.adminButton.BackgroundImage = global::İlan_Sitesi_Proje.Properties.Resources.control_panel;
            this.adminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.adminButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adminButton.Location = new System.Drawing.Point(96, 285);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(319, 100);
            this.adminButton.TabIndex = 7;
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Visible = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // merhaba_label
            // 
            this.merhaba_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.merhaba_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.merhaba_label.Location = new System.Drawing.Point(3, 61);
            this.merhaba_label.Name = "merhaba_label";
            this.merhaba_label.Size = new System.Drawing.Size(509, 38);
            this.merhaba_label.TabIndex = 5;
            this.merhaba_label.Text = "MERHABA, KULLANICI";
            this.merhaba_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(96, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(319, 73);
            this.button6.TabIndex = 4;
            this.button6.Text = "Çıkış Yap";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Purple;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(96, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(319, 73);
            this.button5.TabIndex = 3;
            this.button5.Text = "Üye Paneli";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // islemPanel
            // 
            this.islemPanel.Controls.Add(this.label1);
            this.islemPanel.Controls.Add(this.button1);
            this.islemPanel.Controls.Add(this.button2);
            this.islemPanel.Location = new System.Drawing.Point(533, 12);
            this.islemPanel.Name = "islemPanel";
            this.islemPanel.Size = new System.Drawing.Size(515, 406);
            this.islemPanel.TabIndex = 21;
            // 
            // anaProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1060, 430);
            this.Controls.Add(this.islemPanel);
            this.Controls.Add(this.girisPanel);
            this.Controls.Add(this.uyePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "anaProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlan Programı Ana Menü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.girisPanel.ResumeLayout(false);
            this.girisPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uyePanel.ResumeLayout(false);
            this.islemPanel.ResumeLayout(false);
            this.islemPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label hata_label;
        private System.Windows.Forms.Panel girisPanel;
        private System.Windows.Forms.Panel islemPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel uyePanel;
        private System.Windows.Forms.Label merhaba_label;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox beniHatirla;
    }
}

