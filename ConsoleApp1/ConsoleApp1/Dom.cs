using System;

namespace ConsoleApp1
{
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

	public void WydrukujStanDomu(string kogo)
    {
		System.Console.WriteLine(string.Format("Dom {0} ma drzwi koloru {1}, drzwi te s� z {2} i s� {3}.", kogo, DrzwiDomu.Kolor, DrzwiDomu.Material, DrzwiDomu.Stan));
		System.Console.WriteLine(string.Format("Dom {0} ma okna szeroko�ci {1} wysoko�ci {2} i r�wnie� s� {3}. ", kogo, OknoDomu.Szerokosc, OknoDomu.Wysokosc, OknoDomu.Stan));
		System.Console.WriteLine(string.Format ("W domu {0} �ciany maj� kolor {1}, a dach {2}.\n", kogo, KolorScian, KolorDachu));
    }

  }
}