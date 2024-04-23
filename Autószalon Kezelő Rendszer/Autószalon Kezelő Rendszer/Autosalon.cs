using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autószalon_Kezelő_Rendszer
{
	internal class Autosalon
	{
		public List<Jarmu> Jarmuvek { get; set; }
		public Autosalon()
		{
			Jarmuvek = new List<Jarmu>();
		}
		public void UjJarmuHozzaadasa(Jarmu jarmu)
		{
			Jarmuvek.Add(jarmu);
            Console.WriteLine("Sikeresen hozzáadva a listához.");

        }
		public void JarmuEladasa(string gyarto, string modell)
		{
			bool kimenet = false;
			foreach (var item in Jarmuvek)
			{
				if (item.Gyarto == gyarto && item.Modell == modell)
				{
					Jarmuvek.Remove(item);
					kimenet = true;
				}
			}
			if (kimenet == false)
			{
                Console.WriteLine("Az eladás sikertelen");
            }
			else
			{
                Console.WriteLine("Az eladás sikeres");
            }
		}
		public void JarmuKeresese(string gyarto, string modell)
		{
			foreach(var item in Jarmuvek)
			{
				if(item.Gyarto == gyarto && item.Modell == modell)
				{
                    Console.WriteLine(item);
                }
			}
		}

		public void JarmuvekListazasa()
		{
			foreach (var item in Jarmuvek)
			{
                Console.WriteLine($" Gyártó:{item.Gyarto}, Modell:{item.Modell}, Évjárat:{item.Evjarat}, Alapár: {item.Alapar}, Kilométeróra állás: {item.KilometeroraAllas}");
            }
		}
	}
}
