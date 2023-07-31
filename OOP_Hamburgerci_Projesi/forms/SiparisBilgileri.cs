using OOP_Hamburgerci_Projesi;
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
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            listTumSiparis.Items.Clear();
            foreach (var item in Siparis.SiparisBilgileri)
            {
                listTumSiparis.Items.Add(item);
            }
            txtToplamSiparisSayisi.Text = listTumSiparis.Items.Count.ToString();
            txtEkstraMalzemeGelir.Text = Siparis.EkstraMalzemeGeliri.ToString() + " TL";
            txtCiro.Text = Siparis.Ciro.ToString() + " TL";
            txtSatilanUrunAdet.Text = Siparis.UrunAdet.ToString();
        }
        
    }
}
