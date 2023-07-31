
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
    public partial class MyMDIForm : Form
    {
        public MyMDIForm()
        {
            InitializeComponent();
        }
        private void toolStripSiparisOlustur_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            SiparisOlustur siparis = new SiparisOlustur();
            siparis.MdiParent = this;
            siparis.Show();
            siparis.Activate();
        }
        private void toolStripSiparisBilgileri_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            SiparisBilgileri siparisBilgileri = new SiparisBilgileri();
            siparisBilgileri.MdiParent = this;
            siparisBilgileri.Show();
            siparisBilgileri.Activate();
        }
        private void toolStripMenuEkle_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            MenuEkle menu = new MenuEkle();
            menu.MdiParent = this;
            menu.Show();
            menu.Activate();
        }
        private void toolStripEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            EkstraMalzemeEkle ekstraMalzeme = new EkstraMalzemeEkle();
            ekstraMalzeme.MdiParent = this;
            ekstraMalzeme.Show();
            ekstraMalzeme.Activate();
        }
        private void MyMDIForm_Load(object sender, EventArgs e)
        {

        }
    }
}
