namespace İlan_Sitesi_Proje
{
    partial class adminModelDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminModelDuzenle));
            this.button1 = new System.Windows.Forms.Button();
            this.modelIsmi = new System.Windows.Forms.TextBox();
            this.baslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.markaListesi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(126, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 30);
            this.button1.TabIndex = 41;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modelIsmi
            // 
            this.modelIsmi.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modelIsmi.Location = new System.Drawing.Point(220, 46);
            this.modelIsmi.Name = "modelIsmi";
            this.modelIsmi.Size = new System.Drawing.Size(217, 30);
            this.modelIsmi.TabIndex = 40;
            // 
            // baslik
            // 
            this.baslik.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.baslik.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.baslik.Location = new System.Drawing.Point(220, 9);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(217, 34);
            this.baslik.TabIndex = 39;
            this.baslik.Text = "Model İsmi";
            this.baslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 34);
            this.label1.TabIndex = 42;
            this.label1.Text = "Marka Seçimi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // markaListesi
            // 
            this.markaListesi.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.markaListesi.FormattingEnabled = true;
            this.markaListesi.Location = new System.Drawing.Point(12, 45);
            this.markaListesi.Name = "markaListesi";
            this.markaListesi.Size = new System.Drawing.Size(202, 31);
            this.markaListesi.TabIndex = 43;
            // 
            // adminModelDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(449, 139);
            this.Controls.Add(this.markaListesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modelIsmi);
            this.Controls.Add(this.baslik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminModelDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model Düzenleme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adminModelDuzenle_FormClosed);
            this.Load += new System.EventHandler(this.adminModelDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox modelIsmi;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox markaListesi;
    }
}