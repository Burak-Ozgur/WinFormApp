namespace OOP_Hamburgerci_Projesi
{
    partial class MyMDIForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSiparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEkstraMalzemeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSiparisOlustur,
            this.toolStripSiparisBilgileri});
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(153, 29);
            this.siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // toolStripSiparisOlustur
            // 
            this.toolStripSiparisOlustur.Name = "toolStripSiparisOlustur";
            this.toolStripSiparisOlustur.Size = new System.Drawing.Size(229, 34);
            this.toolStripSiparisOlustur.Text = "Sipariş Oluştur";
            this.toolStripSiparisOlustur.Click += new System.EventHandler(this.toolStripSiparisOlustur_Click);
            // 
            // toolStripSiparisBilgileri
            // 
            this.toolStripSiparisBilgileri.Name = "toolStripSiparisBilgileri";
            this.toolStripSiparisBilgileri.Size = new System.Drawing.Size(229, 34);
            this.toolStripSiparisBilgileri.Text = "Sipariş Bilgileri";
            this.toolStripSiparisBilgileri.Click += new System.EventHandler(this.toolStripSiparisBilgileri_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuEkle,
            this.toolStripEkstraMalzemeEkle});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // toolStripMenuEkle
            // 
            this.toolStripMenuEkle.Name = "toolStripMenuEkle";
            this.toolStripMenuEkle.Size = new System.Drawing.Size(273, 34);
            this.toolStripMenuEkle.Text = "Menü Ekle";
            this.toolStripMenuEkle.Click += new System.EventHandler(this.toolStripMenuEkle_Click);
            // 
            // toolStripEkstraMalzemeEkle
            // 
            this.toolStripEkstraMalzemeEkle.Name = "toolStripEkstraMalzemeEkle";
            this.toolStripEkstraMalzemeEkle.Size = new System.Drawing.Size(273, 34);
            this.toolStripEkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.toolStripEkstraMalzemeEkle.Click += new System.EventHandler(this.toolStripEkstraMalzemeEkle_Click);
            // 
            // MyMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 646);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MyMDIForm";
            this.Text = "MyMDIForm";
            this.Load += new System.EventHandler(this.MyMDIForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEkle;
        private System.Windows.Forms.ToolStripMenuItem toolStripEkstraMalzemeEkle;
        private System.Windows.Forms.ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripSiparisOlustur;
        private System.Windows.Forms.ToolStripMenuItem toolStripSiparisBilgileri;
    }
}

