using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autószalon_Kezelő_Rendszer
{
	public class Szemelyauto:Jarmu
	{
		public Szemelyauto(string gyarto, string modell, int evjarat, int alapar, int ulesekSzama, double fogyasztas, string szín, int kilometeroraAllas) : base( gyarto,  modell,  evjarat,  alapar,kilometeroraAllas)
		{
			UlesekSzama = ulesekSzama;
			Fogyasztas = fogyasztas;
			Szín = szín;
		}

		public int UlesekSzama { get; set; }
		public double Fogyasztas { get; set; }
		public string Szín { get; set; }


		public void KenyelmiExtraBeszerzese(string extra)
		{
			Alapar += 3000;
            Console.WriteLine($"{extra} hozzá lett adva akocsihoz aminek az új ára:{Alapar}");
        }

		public void SzínFrissítése(string újSzín)
		{
			Szín = újSzín;
		}

	}
}
