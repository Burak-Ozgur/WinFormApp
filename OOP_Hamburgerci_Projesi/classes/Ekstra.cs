using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci_Projesi.classes 
{
    internal class Ekstra
    {
        public static Dictionary<string, decimal> MalzemeToFiyat { get { return _malzemeToFiyat; } set { } }
        static Dictionary<string, decimal> _malzemeToFiyat = new Dictionary<string, decimal>() { { "Ketçap", 2m }, { "Mayonez", 2m }, { "Hardal", 4m }, { "BBQ", 4m } };
    }
}
