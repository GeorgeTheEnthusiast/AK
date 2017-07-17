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
      System.Console.WriteLine(string.Format("Dom {0} ma drzwi koloru {1}, drzwi te s¹ z {2} i s¹ {3}.", Kogo.pobierzWlasciciela(), DrzwiDomu.Kolor, DrzwiDomu.Material, DrzwiDomu.pobierzStan()));
      System.Console.WriteLine(string.Format("Dom {0} ma okna szerokoœci {1} wysokoœci {2} i równie¿ s¹ {3}. ", Kogo.pobierzWlasciciela(), OknoDomu.Szerokosc, OknoDomu.Wysokosc, OknoDomu.pobierzStan()));
      System.Console.WriteLine(string.Format ("W domu {0} œciany maj¹ kolor {1}, a dach {2}.\n", Kogo.pobierzWlasciciela(), KolorScian, KolorDachu));
    }
  }
}