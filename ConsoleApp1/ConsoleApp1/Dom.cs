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

    public void WydrukujStanDomu(string kogo)
    {


      System.Console.WriteLine(string.Format("Dom {0} ma drzwi koloru {1}, drzwi te s¹ z {2} i s¹ {3}.", kogo, DrzwiDomu.Kolor, DrzwiDomu.Material, DrzwiDomu.Stan));
			System.Console.WriteLine(String.Format("Dom {0} ma okna szerokoœci {1} wysokoœci {2} i równie¿ jest {3} ", kogo, OknoDomu.Szerokosc, OknoDomu.Wysokosc, OknoDomu.Stan));
			System.Console.WriteLine("W domu œciany maj¹ kolor " + KolorScian + ", a dach " + KolorDachu + ".");
    }

    public void ZmienKolorDachu(string kolor)
    {
      KolorDachu = kolor;
    }
  }
}