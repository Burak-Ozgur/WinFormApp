namespace OOP_Hamburgerci_Projesi
{
    partial class EkstraMalzemeEkle
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
            this.grpEkstraMalzeme = new System.Windows.Forms.GroupBox();
            this.numericEkstraFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnEkstraMalzemeKaydet = new System.Windows.Forms.Button();
            this.lblEkstraMalzemeAd = new System.Windows.Forms.Label();
            this.txtEkstraMalzeme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpEkstraMalzeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEkstraFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEkstraMalzeme
            // 
            this.grpEkstraMalzeme.Controls.Add(this.numericEkstraFiyat);
            this.grpEkstraMalzeme.Controls.Add(this.btnEkstraMalzemeKaydet);
            this.grpEkstraMalzeme.Controls.Add(this.lblEkstraMalzemeAd);
            this.grpEkstraMalzeme.Controls.Add(this.txtEkstraMalzeme);
            this.grpEkstraMalzeme.Controls.Add(this.label2);
            this.grpEkstraMalzeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEkstraMalzeme.Location = new System.Drawing.Point(12, 12);
            this.grpEkstraMalzeme.Name = "grpEkstraMalzeme";
            this.grpEkstraMalzeme.Size = new System.Drawing.Size(452, 185);
            this.grpEkstraMalzeme.TabIndex = 7;
            this.grpEkstraMalzeme.TabStop = false;
            this.grpEkstraMalzeme.Text = "Ekstra Malzeme Bilgileri";
            // 
            // numericEkstraFiyat
            // 
            this.numericEkstraFiyat.DecimalPlaces = 2;
            this.numericEkstraFiyat.Location = new System.Drawing.Point(180, 72);
            this.numericEkstraFiyat.Name = "numericEkstraFiyat";
            this.numericEkstraFiyat.Size = new System.Drawing.Size(245, 30);
            this.numericEkstraFiyat.TabIndex = 6;
            this.numericEkstraFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericEkstraFiyat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEkstraMalzemeKaydet
            // 
            this.btnEkstraMalzemeKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkstraMalzemeKaydet.Location = new System.Drawing.Point(180, 117);
            this.btnEkstraMalzemeKaydet.Name = "btnEkstraMalzemeKaydet";
            this.btnEkstraMalzemeKaydet.Size = new System.Drawing.Size(245, 55);
            this.btnEkstraMalzemeKaydet.TabIndex = 4;
            this.btnEkstraMalzemeKaydet.Text = "Ekstra Malzemeyi Kaydet";
            this.btnEkstraMalzemeKaydet.UseVisualStyleBackColor = true;
            this.btnEkstraMalzemeKaydet.Click += new System.EventHandler(this.btnEkstraMalzemeKaydet_Click);
            // 
            // lblEkstraMalzemeAd
            // 
            this.lblEkstraMalzemeAd.AutoSize = true;
            this.lblEkstraMalzemeAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEkstraMalzemeAd.Location = new System.Drawing.Point(6, 39);
            this.lblEkstraMalzemeAd.Name = "lblEkstraMalzemeAd";
            this.lblEkstraMalzemeAd.Size = new System.Drawing.Size(168, 20);
            this.lblEkstraMalzemeAd.TabIndex = 0;
            this.lblEkstraMalzemeAd.Text = "Ekstra Malzeme Adı";
            this.lblEkstraMalzemeAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEkstraMalzeme
            // 
            this.txtEkstraMalzeme.Location = new System.Drawing.Point(180, 32);
            this.txtEkstraMalzeme.Name = "txtEkstraMalzeme";
            this.txtEkstraMalzeme.Size = new System.Drawing.Size(245, 30);
            this.txtEkstraMalzeme.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EkstraMalzemeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 210);
            this.Controls.Add(this.grpEkstraMalzeme);
            this.Name = "EkstraMalzemeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ekstra Malzeme Ekle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpEkstraMalzeme.ResumeLayout(false);
            this.grpEkstraMalzeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEkstraFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEkstraMalzeme;
        private System.Windows.Forms.NumericUpDown numericEkstraFiyat;
        private System.Windows.Forms.Button btnEkstraMalzemeKaydet;
        private System.Windows.Forms.Label lblEkstraMalzemeAd;
        private System.Windows.Forms.TextBox txtEkstraMalzeme;
        private System.Windows.Forms.Label label2;
    }
}