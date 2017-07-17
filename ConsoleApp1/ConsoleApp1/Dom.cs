using System;

namespace ConsoleApp1
{
  internal class Dom
  {
    public string KolorScian = "szary";
    public string KolorDachu = "zielony";
    public Drzwi DrzwiDomu; // = new Drzwi();
    public Okno OknoDomu;
    public CzyjDom Kogo;
    //string wlasciciel;
    public Dom()
    {
      DrzwiDomu = new Drzwi();
      OknoDomu = new Okno();
      Kogo = new CzyjDom();
    }

    public void ZmienKolorScian(string kolor)
    {
    KolorScian = kolor;
    }

  public void ZmienKolorDachu(string kolor)
  {
    KolorDachu = kolor;
  }

  public void WydrukujStanDomu()

    {
      Okno okno = new Okno();
      System.Console.WriteLine(string.Format("Dom {0} ma drzwi koloru {1}, drzwi te s� z {2} i s� {3}.", Kogo.pobierzWlasciciela(), DrzwiDomu.Kolor, DrzwiDomu.Material, DrzwiDomu.pobierzStan()));
      System.Console.WriteLine(string.Format("Dom {0} ma okna szeroko�ci {1} wysoko�ci {2} i r�wnie� s� {3}. ", Kogo.pobierzWlasciciela(), OknoDomu.Szerokosc, OknoDomu.Wysokosc, OknoDomu.pobierzStan()));
      System.Console.WriteLine(string.Format ("W domu {0} �ciany maj� kolor {1}, a dach {2}.\n", Kogo.pobierzWlasciciela(), KolorScian, KolorDachu));
    }
  }
}