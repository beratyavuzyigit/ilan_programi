namespace İlan_Sitesi_Proje
{
    partial class adminOnaysizIlanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminOnaysizIlanlar));
            this.ilanListesi = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.onayla = new System.Windows.Forms.Button();
            this.duzenle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ilanListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ilanListesi
            // 
            this.ilanListesi.AllowUserToAddRows = false;
            this.ilanListesi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ilanListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ilanListesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ilanListesi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ilanListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ilanListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ilanListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.ilanListesi.Location = new System.Drawing.Point(12, 65);
            this.ilanListesi.Name = "ilanListesi";
            this.ilanListesi.ReadOnly = true;
            this.ilanListesi.RowHeadersVisible = false;
            this.ilanListesi.RowHeadersWidth = 300;
            this.ilanListesi.RowTemplate.Height = 100;
            this.ilanListesi.Size = new System.Drawing.Size(940, 699);
            this.ilanListesi.TabIndex = 33;
            this.ilanListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ilanListesi_CellMouseClick);
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchButton.Location = new System.Drawing.Point(300, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(135, 43);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "İlan Ara";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchText.Location = new System.Drawing.Point(61, 12);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(233, 43);
            this.searchText.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::İlan_Sitesi_Proje.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // onayla
            // 
            this.onayla.BackColor = System.Drawing.Color.Transparent;
            this.onayla.BackgroundImage = global::İlan_Sitesi_Proje.Properties.Resources.confirm;
            this.onayla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.onayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onayla.Enabled = false;
            this.onayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onayla.ForeColor = System.Drawing.Color.Transparent;
            this.onayla.Location = new System.Drawing.Point(895, 6);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(57, 51);
            this.onayla.TabIndex = 28;
            this.onayla.UseVisualStyleBackColor = false;
            this.onayla.Click += new System.EventHandler(this.onayla_Click);
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
            this.duzenle.Location = new System.Drawing.Point(832, 6);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(57, 51);
            this.duzenle.TabIndex = 34;
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
            this.sil.Location = new System.Drawing.Point(769, 6);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(57, 51);
            this.sil.TabIndex = 35;
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminOnaysizIlanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(966, 776);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.ilanListesi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.onayla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminOnaysizIlanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Onay Bekleyenler";
            this.Load += new System.EventHandler(this.adminOnaysizIlanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ilanListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ilanListesi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button onayla;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.Button sil;
    }
}