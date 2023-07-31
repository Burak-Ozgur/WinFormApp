using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci_Projesi.classes 
{
    internal class Siparis
    {
		private static List<string> _siparisBilgileri = new List<string> { };

		public static List<string> SiparisBilgileri
		{
			get { return _siparisBilgileri; }
			set { _siparisBilgileri = value; }
		}
		private static decimal _ekstraMalzemeGeliri;

		public static decimal EkstraMalzemeGeliri
		{
			get { return _ekstraMalzemeGeliri; }
			set { _ekstraMalzemeGeliri = value; }
		}
		private static decimal _ciro;
		
		public static decimal Ciro
		{
			get { return _ciro; }
			set { _ciro = value; }
		}
		
		private static int _urunAdet;

		public static int UrunAdet
		{
			get { return _urunAdet; }
			set { _urunAdet = value; }
		}
	}
}
