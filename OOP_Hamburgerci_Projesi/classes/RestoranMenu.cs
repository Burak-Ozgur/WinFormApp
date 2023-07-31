using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci_Projesi.classes
{
    internal class RestoranMenu
    {
        public static Dictionary<string, decimal> Items { get { return _items; } set { } }
        static Dictionary<string, decimal> _items = new Dictionary<string, decimal>() { { "Cheese Burger", 65m }, { "Klasik Burger", 60m }, { "Mantarlı Burger", 60m }, { "Yeni Nesil Burger", 60m } };

    }
}
