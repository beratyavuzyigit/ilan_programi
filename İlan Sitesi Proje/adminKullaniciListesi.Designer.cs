namespace İlan_Sitesi_Proje
{
    partial class adminKullaniciListesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminKullaniciListesi));
            this.kullaniciListesi = new System.Windows.Forms.DataGridView();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yasakla = new System.Windows.Forms.Button();
            this.duzenle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciListesi
            // 
            this.kullaniciListesi.AllowUserToAddRows = false;
            this.kullaniciListesi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kullaniciListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kullaniciListesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kullaniciListesi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kullaniciListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullaniciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kullaniciListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.kullaniciListesi.Location = new System.Drawing.Point(12, 69);
            this.kullaniciListesi.Name = "kullaniciListesi";
            this.kullaniciListesi.ReadOnly = true;
            this.kullaniciListesi.RowHeadersVisible = false;
            this.kullaniciListesi.RowHeadersWidth = 300;
            this.kullaniciListesi.RowTemplate.Height = 30;
            this.kullaniciListesi.Size = new System.Drawing.Size(935, 369);
            this.kullaniciListesi.TabIndex = 14;
            this.kullaniciListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kullaniciListesi_CellContentClick);
            this.kullaniciListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.kullaniciListesi_CellMouseClick);
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchText.Location = new System.Drawing.Point(61, 16);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(233, 43);
            this.searchText.TabIndex = 18;
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchButton.Location = new System.Drawing.Point(300, 16);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(135, 43);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "Kullanıcı Ara";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::İlan_Sitesi_Proje.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // yasakla
            // 
            this.yasakla.BackColor = System.Drawing.Color.Transparent;
            this.yasakla.BackgroundImage = global::İlan_Sitesi_Proje.Properties.Resources.ban;
            this.yasakla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yasakla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yasakla.Enabled = false;
            this.yasakla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yasakla.ForeColor = System.Drawing.Color.Transparent;
            this.yasakla.Location = new System.Drawing.Point(764, 12);
            this.yasakla.Name = "yasakla";
            this.yasakla.Size = new System.Drawing.Size(57, 51);
            this.yasakla.TabIndex = 17;
            this.yasakla.UseVisualStyleBackColor = false;
            this.yasakla.Click += new System.EventHandler(this.yasakla_Click);
            // 
            // duzenle
            // 
            this.duzenle.BackColor = System.Drawing.Color.Transparent;
            this.duzenle.BackgroundImage = global::İlan_Sitesi_Proje.Properties.Resources.edit;
            this.duzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.duzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duzenle.Enabled = false;
            this.duzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duzenle.ForeColor = System.Drawing.Color.Transparent;
            this.duzenle.Location = new System.Drawing.Point(827, 12);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(57, 51);
            this.duzenle.TabIndex = 16;
            this.duzenle.UseVisualStyleBackColor = false;
            this.duzenle.Click += new System.EventHandler(this.duzenle_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Transparent;
            this.sil.BackgroundImage = global::İlan_Sitesi_Proje.Properties.Resources.delete;
            this.sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil.Enabled = false;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.ForeColor = System.Drawing.Color.Transparent;
            this.sil.Location = new System.Drawing.Point(890, 12);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(57, 51);
            this.sil.TabIndex = 15;
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // adminKullaniciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.yasakla);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.kullaniciListesi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminKullaniciListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Listesi";
            this.Load += new System.EventHandler(this.adminKullaniciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kullaniciListesi;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.Button yasakla;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}