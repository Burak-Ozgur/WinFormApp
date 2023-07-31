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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_Hamburgerci_Projesi
{
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }
        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                RestoranMenu.Items.Add(txtMenuAdi.Text, numericFiyat.Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Bu isimde bir menü mevcut.");
            }
        }
    }
}
