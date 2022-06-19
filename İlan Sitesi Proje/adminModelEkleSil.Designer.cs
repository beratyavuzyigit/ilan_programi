namespace İlan_Sitesi_Proje
{
    partial class adminModelEkleSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminModelEkleSil));
            this.modelListesi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.markaListesi = new System.Windows.Forms.ComboBox();
            this.baslik = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.modelIsmi = new System.Windows.Forms.TextBox();
            this.duzenle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modelListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelListesi
            // 
            this.modelListesi.AllowUserToAddRows = false;
            this.modelListesi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.modelListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.modelListesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.modelListesi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modelListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.modelListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.modelListesi.Location = new System.Drawing.Point(12, 12);
            this.modelListesi.Name = "modelListesi";
            this.modelListesi.ReadOnly = true;
            this.modelListesi.RowHeadersVisible = false;
            this.modelListesi.RowHeadersWidth = 300;
            this.modelListesi.RowTemplate.Height = 30;
            this.modelListesi.Size = new System.Drawing.Size(533, 233);
            this.modelListesi.TabIndex = 26;
            this.modelListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.markaListesi_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.markaListesi);
            this.groupBox1.Controls.Add(this.baslik);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.modelIsmi);
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model Ekle";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(188, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "Model İsmi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // markaListesi
            // 
            this.markaListesi.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.markaListesi.FormattingEnabled = true;
            this.markaListesi.Items.AddRange(new object[] {
            "Seçiniz..."});
            this.markaListesi.Location = new System.Drawing.Point(6, 63);
            this.markaListesi.Name = "markaListesi";
            this.markaListesi.Size = new System.Drawing.Size(175, 31);
            this.markaListesi.TabIndex = 39;
            // 
            // baslik
            // 
            this.baslik.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.baslik.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.baslik.Location = new System.Drawing.Point(6, 32);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(147, 28);
            this.baslik.TabIndex = 38;
            this.baslik.Text = "Marka Seçimi";
            this.baslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(393, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 30);
            this.button1.TabIndex = 37;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modelIsmi
            // 
            this.modelIsmi.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modelIsmi.Location = new System.Drawing.Point(187, 64);
            this.modelIsmi.Name = "modelIsmi";
            this.modelIsmi.Size = new System.Drawing.Size(200, 30);
            this.modelIsmi.TabIndex = 36;
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
            this.duzenle.Location = new System.Drawing.Point(551, 12);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(57, 51);
            this.duzenle.TabIndex = 24;
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
            this.sil.Location = new System.Drawing.Point(551, 69);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(57, 51);
            this.sil.TabIndex = 23;
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // adminModelEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(618, 364);
            this.Controls.Add(this.modelListesi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.sil);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminModelEkleSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model Ekle/Sil";
            this.Load += new System.EventHandler(this.adminModelEkleSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelListesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView modelListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox modelIsmi;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox markaListesi;
        private System.Windows.Forms.Label baslik;
    }
}