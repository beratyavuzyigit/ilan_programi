namespace İlan_Sitesi_Proje
{
    partial class adminMarkaDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminMarkaDuzenle));
            this.baslik = new System.Windows.Forms.Label();
            this.markaIsmi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baslik
            // 
            this.baslik.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.baslik.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.baslik.Location = new System.Drawing.Point(12, 9);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(425, 34);
            this.baslik.TabIndex = 30;
            this.baslik.Text = "Marka İsmi";
            this.baslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // markaIsmi
            // 
            this.markaIsmi.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markaIsmi.Location = new System.Drawing.Point(12, 46);
            this.markaIsmi.Name = "markaIsmi";
            this.markaIsmi.Size = new System.Drawing.Size(425, 30);
            this.markaIsmi.TabIndex = 37;
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
            this.button1.TabIndex = 38;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminMarkaDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(449, 133);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.markaIsmi);
            this.Controls.Add(this.baslik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminMarkaDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka Düzenle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adminMarkaDuzenle_FormClosed);
            this.Load += new System.EventHandler(this.adminMarkaDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.TextBox markaIsmi;
        private System.Windows.Forms.Button button1;
    }
}