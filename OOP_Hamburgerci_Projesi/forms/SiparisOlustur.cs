
using OOP_Hamburgerci_Projesi.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci_Projesi
{
    public partial class SiparisOlustur : Form
    {
        #region Metodlar:
        public void MenuAdiAl()
        {
            foreach (var item in RestoranMenu.Items.Keys)
            {
                cmbMenu.Items.Add(item);
            }
        }
        public void SosAdiAl()
        {
            foreach (var item in Ekstra.MalzemeToFiyat.Keys)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = item;
                flpMalzemeSecim.Controls.Add(checkBox);
            }
        }
        public decimal MenuFiyatAl()
        {
            return RestoranMenu.Items[this.cmbMenu.GetItemText(this.cmbMenu.SelectedItem)];
        }
        public decimal BoyAl()
        {
            decimal fiyat = 0;
            foreach (RadioButton rdBut in grpBoyutSecim.Controls)
            {
                if (rdBut.Checked)
                {
                    if (rdBut.Text == "Küçük")
                    {
                        fiyat = 0m;
                    }
                    else if (rdBut.Text == "Orta")
                    {
                        fiyat = 10m;
                    }
                    else if (rdBut.Text == "Büyük")
                    {
                        fiyat = 20m;
                    }
                }
            }
            return fiyat;
        }
        public decimal EkstraFiyatAl()
        {
            decimal ekFiyat = 0;
            foreach (CheckBox items in flpMalzemeSecim.Controls)
            {
                if (items.Checked)
                {
                    ekFiyat += Ekstra.MalzemeToFiyat[items.Text];
                }
            }
            return ekFiyat;
        }
        public void ListeOlustur() 
        {
            string menuBilgisi = string.Empty;
            menuBilgisi += cmbMenu.SelectedItem.ToString() + " X " + numAdet.Value.ToString() + ", ";
            foreach (RadioButton boy in grpBoyutSecim.Controls)
            {
                if (boy.Checked)
                {
                    menuBilgisi += boy.Text + ", ";
                }
            }
            foreach (CheckBox sos in flpMalzemeSecim.Controls)
            {
                if (sos.Checked)
                {
                    menuBilgisi += sos.Text + ", ";
                }
            }
            int index = menuBilgisi.LastIndexOf(", ");
            menuBilgisi.Remove(index);
            Siparis.SiparisBilgileri.Add(menuBilgisi + "Tutar = " + siparisTutari.ToString() + "\n");
            listSiparis.Items.Add(menuBilgisi);
        } 
        public void GetSiparisBilgileri()
        {
            SiparisBilgileri siparisBilgileri = new SiparisBilgileri();
            siparisBilgileri.MdiParent = this.MdiParent;
            siparisBilgileri.Show();
            this.Close();
        }
        public decimal CiroHesapla()
        {
            decimal menuTutar = MenuFiyatAl();
            decimal ekstraTutar = EkstraFiyatAl();
            decimal boyTutar = BoyAl();
            decimal ciroTutar = menuTutar + ekstraTutar + boyTutar;
            return ciroTutar;
        }
        public void SetDefault()
        {
            cmbMenu.SelectedIndex = 0;
            rdBtnKucuk.Checked = true;
            foreach (CheckBox item in flpMalzemeSecim.Controls)
            {
                item.Checked = false;
            }
            numAdet.Value = 1;
        }
        #endregion
        #region:Properties
        decimal siparisTutari = 0;
        decimal tutar = 0;
        #endregion
        public SiparisOlustur()
        {
            InitializeComponent();
            MenuAdiAl();
            SosAdiAl();
            SetDefault();
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            
            Siparis.EkstraMalzemeGeliri += EkstraFiyatAl();
            Siparis.Ciro += CiroHesapla();
            Siparis.UrunAdet += (int)numAdet.Value;
            siparisTutari = ((MenuFiyatAl() + BoyAl() + EkstraFiyatAl()) * numAdet.Value);
            tutar += ((MenuFiyatAl()+BoyAl()+EkstraFiyatAl())*numAdet.Value);
            lblTutar.Text = "Toplam = " + tutar.ToString() + "TL";
            ListeOlustur();
            SetDefault();
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show($"Toplam Tutar = {tutar} TL\nSiparişi tamamlamak ister misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                tutar = 0;
                SiparisOlustur siparis = new SiparisOlustur();
                GetSiparisBilgileri();
            }
            if (dr == DialogResult.No)
            {
                MessageBox.Show("Siparişe devam edebilirsiniz.");
            }
        }
    }
}


