namespace ConsoleApp1
{
  internal class Drzwi
  {
    public string Material = "drewna";
    public string Kolor = "orzech";
    private string Stan;

    public Drzwi()
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