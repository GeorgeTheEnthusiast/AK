namespace ConsoleApp1
{
  internal class Okno
  {
    public double Szerokosc = 1.4;
    public double Wysokosc = 0.9;
    private string Stan;

    public Okno()
    {
      Zamknij();
    }

    public void Otworz()
    {
      Stan = "Otwarte";
    }

    public void Zamknij()
    {
      Stan = "Zamkniête";
    }
    public string pobierzStan()
    {
      return Stan;
    }
  }
}