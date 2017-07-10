using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
	{

		static void Main(string[] args)
		{
			Drzwi drzwiJasia = new Drzwi();
			drzwiJasia.Kolor = "brązowy";
			drzwiJasia.Material = "drewno";
			drzwiJasia.Stan = "zamknięte";

			Okno oknoJasia = new Okno();
			oknoJasia.Szerokosc = 0.5;
			oknoJasia.Wysokosc = 1;
			oknoJasia.Stan = "zamknięte";

			Dom domJasia = new Dom();
			domJasia.DrzwiDomu = drzwiJasia;
			domJasia.OknoDomu = oknoJasia;
			domJasia.KolorScian = "biały";
			domJasia.KolorDachu = "czarny";

			Drzwi drzwiAni = new Drzwi();
			drzwiAni.Kolor = "orzech";
			drzwiAni.Material = "drewno";
			drzwiAni.Stan = "otwarte";

			Okno oknoAni = new Okno();
			oknoAni.Szerokosc = 0.9;
			oknoAni.Wysokosc = 1.5;
			oknoAni.Stan = "zamknięte";

			Dom domAni = new Dom();
			domAni.DrzwiDomu = drzwiAni;
			domAni.OknoDomu = oknoAni;
			domAni.KolorScian = "szary";
			domAni.KolorDachu = "zielony";


      domJasia.WydrukujStanDomu();
		  drzwiJasia.Kolor = "zielony";

      domAni.WydrukujStanDomu();


      

			Console.ReadLine();

		}
	}
}
