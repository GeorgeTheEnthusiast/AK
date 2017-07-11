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
			drzwiJasia.Material = "drewna";
			drzwiJasia.Zamknij();

			Okno oknoJasia = new Okno();
			oknoJasia.Szerokosc = 0.5;
			oknoJasia.Wysokosc = 1;
			oknoJasia.Zamknij();

			Dom domJasia = new Dom();
			domJasia.DrzwiDomu = drzwiJasia;
			domJasia.OknoDomu = oknoJasia;
			domJasia.KolorScian = "biały";
			domJasia.KolorDachu = "czarny";

			Drzwi drzwiAni = new Drzwi();
			drzwiAni.Kolor = "orzech";
			drzwiAni.Material = "drewna";
			drzwiAni.Otworz();

			Okno oknoAni = new Okno();
			oknoAni.Szerokosc = 0.9;
			oknoAni.Wysokosc = 1.5;
			oknoAni.Zamknij();

			Dom domAni = new Dom();
			domAni.DrzwiDomu = drzwiAni;
			domAni.OknoDomu = oknoAni;
			domAni.KolorScian = "szary";
			domAni.KolorDachu = "zielony";


			domJasia.WydrukujStanDomu("Jasia");
			domAni.WydrukujStanDomu("Ani");

			drzwiJasia.Kolor = "zielony";
			drzwiAni.Otworz();
			oknoAni.Szerokosc = 1;
			oknoAni.Wysokosc = 1.2;
			domAni.KolorDachu = "czerwony";

			domAni.WydrukujStanDomu("Ani");

			domJasia.WydrukujStanDomu("Jasia");
			oknoJasia.Otworz();
			drzwiAni.Otworz();




			Console.ReadLine();

		}
	}
}
