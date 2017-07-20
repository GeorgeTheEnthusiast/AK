using System;

namespace ConsoleApp1
{
  public class Dom
  {
    //public Drzwi DrzwiDomu; // = new Drzwi();
    public Okno OknoDomu;
		Drzwi drzwi = new Drzwi();
		public string Wlasciciel;
		public string KolorDachuDomu;
		public string KolorScianDomu;
    

    public Dom(string nazwaDomu)
    {
      OknoDomu = new Okno();
			Wlasciciel = nazwaDomu;

    }

		public enum ZmienKolorDachuDomu
		{
			Zielony,
			Czewony,
			Szary
		}

		public enum ZmienKolorScianDomu
		{
			Szary,
			Bialy,
			Brzoskwinia

		}

  public void WydrukujStanDomu()
  {
      System.Console.WriteLine(string.Format("Dom {0} ma drzwi koloru {1}, drzwi te s¹ z {2} i s¹ {3}.", Wlasciciel, Drzwi.ZmienKolorDrzwi.Orzech, Drzwi.ZmienMaterialDrzwi.Drewno, drzwi.pobierzStan()));
      System.Console.WriteLine(string.Format("Dom {0} ma okna szerokoœci {1} wysokoœci {2} i równie¿ s¹ {3}. ", Wlasciciel, OknoDomu.Szerokosc, OknoDomu.Wysokosc, OknoDomu.pobierzStan()));
      System.Console.WriteLine(string.Format ("W domu {0} œciany maj¹ kolor {1}, a dach {2}.\n", Wlasciciel, ZmienKolorScianDomu.Szary, ZmienKolorDachuDomu.Zielony));
    }
  }
}