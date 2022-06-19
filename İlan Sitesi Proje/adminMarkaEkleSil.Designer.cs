namespace İlan_Sitesi_Proje
{
    partial class adminMarkaEkleSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminMarkaEkleSil));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.markaIsmi = new System.Windows.Forms.TextBox();
            this.markaListesi = new System.Windows.Forms.DataGridView();
            this.duzenle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markaListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.markaIsmi);
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marka Ekle";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(393, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 30);
            this.button1.TabIndex = 37;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // markaIsmi
            // 
            this.markaIsmi.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markaIsmi.Location = new System.Drawing.Point(6, 41);
            this.markaIsmi.Name = "markaIsmi";
            this.markaIsmi.Size = new System.Drawing.Size(381, 30);
            this.markaIsmi.TabIndex = 36;
            // 
            // markaListesi
            // 
            this.markaListesi.AllowUserToAddRows = false;
            this.markaListesi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.markaListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.markaListesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.markaListesi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.markaListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.markaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.markaListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.markaListesi.Location = new System.Drawing.Point(12, 12);
            this.markaListesi.Name = "markaListesi";
            this.markaListesi.ReadOnly = true;
            this.markaListesi.RowHeadersVisible = false;
            this.markaListesi.RowHeadersWidth = 300;
            this.markaListesi.RowTemplate.Height = 30;
            this.markaListesi.Size = new System.Drawing.Size(533, 233);
            this.markaListesi.TabIndex = 22;
            this.markaListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.markaListesi_CellMouseClick);
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
            this.duzenle.TabIndex = 19;
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
            this.sil.TabIndex = 18;
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // adminMarkaEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 363);
            this.Controls.Add(this.markaListesi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.sil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminMarkaEkleSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka Ekle/Sil";
            this.Load += new System.EventHandler(this.adminMarkaEkleSil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markaListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox markaIsmi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView markaListesi;
    }
}