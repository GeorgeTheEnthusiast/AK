namespace ConsoleApp1
{
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
      Stan = "Zamkniête";
    }
  }
}