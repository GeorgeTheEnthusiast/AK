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
      System.Console.WriteLine(string.Format("Dom {0} ma drzwi koloru {1}, drzwi te s� z {2} i s� {3}.", Wlasciciel, Drzwi.ZmienKolorDrzwi.Orzech, Drzwi.ZmienMaterialDrzwi.Drewno, drzwi.pobierzStan()));
      System.Console.WriteLine(string.Format("Dom {0} ma okna szeroko�ci {1} wysoko�ci {2} i r�wnie� s� {3}. ", Wlasciciel, OknoDomu.Szerokosc, OknoDomu.Wysokosc, OknoDomu.pobierzStan()));
      System.Console.WriteLine(string.Format ("W domu {0} �ciany maj� kolor {1}, a dach {2}.\n", Wlasciciel, ZmienKolorScianDomu.Szary, ZmienKolorDachuDomu.Zielony));
    }
  }
}