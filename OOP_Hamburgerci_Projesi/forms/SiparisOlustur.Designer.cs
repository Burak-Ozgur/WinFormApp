namespace OOP_Hamburgerci_Projesi
{
    partial class SiparisOlustur
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
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblMalzemeSecimi = new System.Windows.Forms.Label();
            this.grpBoyutSecim = new System.Windows.Forms.GroupBox();
            this.rdBtnKucuk = new System.Windows.Forms.RadioButton();
            this.rdBtnOrta = new System.Windows.Forms.RadioButton();
            this.rdBtnBuyuk = new System.Windows.Forms.RadioButton();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.lblMenuSecim = new System.Windows.Forms.Label();
            this.listSiparis = new System.Windows.Forms.ListBox();
            this.flpMalzemeSecim = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoyutSecim.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTutar.Location = new System.Drawing.Point(469, 554);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(132, 25);
            this.lblTutar.TabIndex = 59;
            this.lblTutar.Text = "Tutar = 0 TL";
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(682, 525);
            this.btnSiparisiTamamla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(160, 71);
            this.btnSiparisiTamamla.TabIndex = 58;
            this.btnSiparisiTamamla.Text = "Siparişi Tamamla";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisEkle.Location = new System.Drawing.Point(301, 531);
            this.btnSiparisEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(160, 71);
            this.btnSiparisEkle.TabIndex = 56;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // numAdet
            // 
            this.numAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numAdet.Location = new System.Drawing.Point(93, 548);
            this.numAdet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(180, 26);
            this.numAdet.TabIndex = 55;
            this.numAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_Hamburgerci_Projesi.Properties.Resources.hamburgerimages;
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 145);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.Location = new System.Drawing.Point(13, 548);
            this.lblAdet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(57, 25);
            this.lblAdet.TabIndex = 53;
            this.lblAdet.Text = "Adet";
            // 
            // lblMalzemeSecimi
            // 
            this.lblMalzemeSecimi.AutoSize = true;
            this.lblMalzemeSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMalzemeSecimi.Location = new System.Drawing.Point(33, 317);
            this.lblMalzemeSecimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMalzemeSecimi.Name = "lblMalzemeSecimi";
            this.lblMalzemeSecimi.Size = new System.Drawing.Size(170, 25);
            this.lblMalzemeSecimi.TabIndex = 42;
            this.lblMalzemeSecimi.Text = "Malzeme Seçimi";
            // 
            // grpBoyutSecim
            // 
            this.grpBoyutSecim.Controls.Add(this.rdBtnKucuk);
            this.grpBoyutSecim.Controls.Add(this.rdBtnOrta);
            this.grpBoyutSecim.Controls.Add(this.rdBtnBuyuk);
            this.grpBoyutSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoyutSecim.Location = new System.Drawing.Point(13, 226);
            this.grpBoyutSecim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoyutSecim.Name = "grpBoyutSecim";
            this.grpBoyutSecim.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoyutSecim.Size = new System.Drawing.Size(252, 80);
            this.grpBoyutSecim.TabIndex = 46;
            this.grpBoyutSecim.TabStop = false;
            this.grpBoyutSecim.Text = "Boyut Seçimi";
            // 
            // rdBtnKucuk
            // 
            this.rdBtnKucuk.AutoSize = true;
            this.rdBtnKucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnKucuk.Location = new System.Drawing.Point(0, 29);
            this.rdBtnKucuk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnKucuk.Name = "rdBtnKucuk";
            this.rdBtnKucuk.Size = new System.Drawing.Size(80, 24);
            this.rdBtnKucuk.TabIndex = 6;
            this.rdBtnKucuk.TabStop = true;
            this.rdBtnKucuk.Text = "Küçük";
            this.rdBtnKucuk.UseVisualStyleBackColor = true;
            // 
            // rdBtnOrta
            // 
            this.rdBtnOrta.AutoSize = true;
            this.rdBtnOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnOrta.Location = new System.Drawing.Point(102, 29);
            this.rdBtnOrta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnOrta.Name = "rdBtnOrta";
            this.rdBtnOrta.Size = new System.Drawing.Size(67, 24);
            this.rdBtnOrta.TabIndex = 7;
            this.rdBtnOrta.TabStop = true;
            this.rdBtnOrta.Text = "Orta";
            this.rdBtnOrta.UseVisualStyleBackColor = true;
            // 
            // rdBtnBuyuk
            // 
            this.rdBtnBuyuk.AutoSize = true;
            this.rdBtnBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnBuyuk.Location = new System.Drawing.Point(172, 29);
            this.rdBtnBuyuk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnBuyuk.Name = "rdBtnBuyuk";
            this.rdBtnBuyuk.Size = new System.Drawing.Size(80, 24);
            this.rdBtnBuyuk.TabIndex = 8;
            this.rdBtnBuyuk.TabStop = true;
            this.rdBtnBuyuk.Text = "Büyük";
            this.rdBtnBuyuk.UseVisualStyleBackColor = true;
            // 
            // cmbMenu
            // 
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(13, 187);
            this.cmbMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(250, 28);
            this.cmbMenu.TabIndex = 45;
            // 
            // lblMenuSecim
            // 
            this.lblMenuSecim.AutoSize = true;
            this.lblMenuSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuSecim.Location = new System.Drawing.Point(23, 161);
            this.lblMenuSecim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuSecim.Name = "lblMenuSecim";
            this.lblMenuSecim.Size = new System.Drawing.Size(137, 25);
            this.lblMenuSecim.TabIndex = 44;
            this.lblMenuSecim.Text = "Menü Seçimi";
            // 
            // listSiparis
            // 
            this.listSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSiparis.FormattingEnabled = true;
            this.listSiparis.ItemHeight = 25;
            this.listSiparis.Location = new System.Drawing.Point(301, 14);
            this.listSiparis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listSiparis.Name = "listSiparis";
            this.listSiparis.Size = new System.Drawing.Size(541, 504);
            this.listSiparis.TabIndex = 43;
            // 
            // flpMalzemeSecim
            // 
            this.flpMalzemeSecim.AutoScroll = true;
            this.flpMalzemeSecim.Location = new System.Drawing.Point(12, 345);
            this.flpMalzemeSecim.Name = "flpMalzemeSecim";
            this.flpMalzemeSecim.Size = new System.Drawing.Size(261, 194);
            this.flpMalzemeSecim.TabIndex = 60;
            // 
            // SiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 626);
            this.Controls.Add(this.flpMalzemeSecim);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.numAdet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblMalzemeSecimi);
            this.Controls.Add(this.grpBoyutSecim);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.lblMenuSecim);
            this.Controls.Add(this.listSiparis);
            this.Name = "SiparisOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Siparis Olustur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SiparisOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoyutSecim.ResumeLayout(false);
            this.grpBoyutSecim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblMalzemeSecimi;
        private System.Windows.Forms.GroupBox grpBoyutSecim;
        private System.Windows.Forms.RadioButton rdBtnKucuk;
        private System.Windows.Forms.RadioButton rdBtnOrta;
        private System.Windows.Forms.RadioButton rdBtnBuyuk;
        private System.Windows.Forms.Label lblMenuSecim;
        private System.Windows.Forms.ListBox listSiparis;
        public System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.FlowLayoutPanel flpMalzemeSecim;
    }
}