using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autószalon_Kezelő_Rendszer
{
	public class Terepjaro : Jarmu
	{
		public Terepjaro(string gyarto, string modell, int evjarat, int alapar, string hajtas, bool offroadKepessegek, int vontatóképesség, int kilometeroraAllas) : base(gyarto, modell, evjarat, alapar, kilometeroraAllas)
		{
			Hajtas = hajtas;
			OffroadKepessegek = offroadKepessegek;
			Vontatóképesség = vontatóképesség;
		}
		public string Hajtas { get; set;}
		public bool OffroadKepessegek { get; set;}

		public int Vontatóképesség { get; set; }

		public void OffroadCsomagFelszerel()
		{
			Alapar += 10000;
            Console.WriteLine($"Sikeresen kiválasztotta az offroad csomagot így az ár:{Alapar}");
			OffroadKepessegek = true;
		}

		public void VontatóképességBeállítása(int képesség)
		{
			Vontatóképesség = képesség;
		}
	}
}
