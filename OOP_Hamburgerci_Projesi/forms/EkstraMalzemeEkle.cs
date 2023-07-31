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
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
        }
        
        private void btnEkstraMalzemeKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Ekstra.MalzemeToFiyat.Add(txtEkstraMalzeme.Text, numericEkstraFiyat.Value); 
            }
            catch (Exception)
            {
                MessageBox.Show("Bu isimde bir malzeme mevcut.");
            }
            
        }
    }
}

