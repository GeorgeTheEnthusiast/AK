using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Drzwi
	{
		public string Material;
		public string Kolor;
		public string Stan;

		public void Otworz()
		{
			Stan = "Otwarte";
		}

		public void Zamknij()
		{
			Stan = "Zamknięte";
		}
	}

	class Okno
	{
		public double Szerokosc;
		public double Wysokosc;
		public string Stan;

		public void Otworz()
		{
			Stan = "Otwarte";
		}

		public void Zamknij()
		{
			Stan = "Zamknięte";
		}
	}

	class Dom
	{
		public string KolorScian;
		public string KolorDachu;
		public Drzwi DrzwiDomu;
		public Okno OknoDomu;

		public void ZmienKolorScian(string kolor)
		{
			KolorScian = kolor;
		}

		public void ZmienKolorDachu(string kolor)
		{
			KolorDachu = kolor;
		}
	}


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

			System.Console.WriteLine("Dom Jasia ma drzwi koloru " + drzwiJasia.Kolor + ". Drzwi te są z " + drzwiJasia.Material + " i są " + drzwiJasia.Stan +".");
			System.Console.WriteLine("Dom Jasia ma okna szerokości " + oknoJasia.Szerokosc + " wysokości " + oknoJasia.Wysokosc + " i są również " + oknoJasia.Stan + ".");
			System.Console.WriteLine("W domu Jasia ściany mają kolor " + domJasia.KolorScian + ", a dach " + domJasia.KolorDachu + ".");

			Console.WriteLine("W domu Ani drzwi są koloru " + drzwiAni.Kolor + " wykonane z materiału " + drzwiAni.Material + " i teraz są " + drzwiAni.Stan + ".");
			Console.WriteLine("Ani dom ma okna " + oknoAni.Szerokosc + " szerokości, " + oknoAni.Wysokosc + " wysokości i jest " + oknoAni.Stan + ".");
			Console.WriteLine("Dom ma ściany koloru " + domAni.KolorScian + " i dach " + domAni.KolorDachu + ".");

			Console.ReadLine();

		}
	}
}
