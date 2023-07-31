namespace OOP_Hamburgerci_Projesi
{
    partial class MenuEkle
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
            this.grpMenuBilgi = new System.Windows.Forms.GroupBox();
            this.numericFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnMenuKaydet = new System.Windows.Forms.Button();
            this.lblMenuAdi = new System.Windows.Forms.Label();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpMenuBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuBilgi
            // 
            this.grpMenuBilgi.Controls.Add(this.numericFiyat);
            this.grpMenuBilgi.Controls.Add(this.btnMenuKaydet);
            this.grpMenuBilgi.Controls.Add(this.lblMenuAdi);
            this.grpMenuBilgi.Controls.Add(this.txtMenuAdi);
            this.grpMenuBilgi.Controls.Add(this.label2);
            this.grpMenuBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenuBilgi.Location = new System.Drawing.Point(12, 12);
            this.grpMenuBilgi.Name = "grpMenuBilgi";
            this.grpMenuBilgi.Size = new System.Drawing.Size(412, 223);
            this.grpMenuBilgi.TabIndex = 6;
            this.grpMenuBilgi.TabStop = false;
            this.grpMenuBilgi.Text = "Menü Bilgileri";
            // 
            // numericFiyat
            // 
            this.numericFiyat.Location = new System.Drawing.Point(139, 91);
            this.numericFiyat.Name = "numericFiyat";
            this.numericFiyat.Size = new System.Drawing.Size(245, 30);
            this.numericFiyat.TabIndex = 6;
            this.numericFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericFiyat.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnMenuKaydet
            // 
            this.btnMenuKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuKaydet.Location = new System.Drawing.Point(139, 139);
            this.btnMenuKaydet.Name = "btnMenuKaydet";
            this.btnMenuKaydet.Size = new System.Drawing.Size(245, 55);
            this.btnMenuKaydet.TabIndex = 4;
            this.btnMenuKaydet.Text = "Menüyü Kaydet";
            this.btnMenuKaydet.UseVisualStyleBackColor = true;
            this.btnMenuKaydet.Click += new System.EventHandler(this.btnMenuKaydet_Click);
            // 
            // lblMenuAdi
            // 
            this.lblMenuAdi.AutoSize = true;
            this.lblMenuAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuAdi.Location = new System.Drawing.Point(49, 39);
            this.lblMenuAdi.Name = "lblMenuAdi";
            this.lblMenuAdi.Size = new System.Drawing.Size(84, 20);
            this.lblMenuAdi.TabIndex = 0;
            this.lblMenuAdi.Text = "Menü Adı";
            this.lblMenuAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(139, 32);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(245, 30);
            this.txtMenuAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 262);
            this.Controls.Add(this.grpMenuBilgi);
            this.Name = "MenuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenuEkle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpMenuBilgi.ResumeLayout(false);
            this.grpMenuBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenuBilgi;
        private System.Windows.Forms.NumericUpDown numericFiyat;
        private System.Windows.Forms.Button btnMenuKaydet;
        private System.Windows.Forms.Label lblMenuAdi;
        private System.Windows.Forms.TextBox txtMenuAdi;
        private System.Windows.Forms.Label label2;
    }
}