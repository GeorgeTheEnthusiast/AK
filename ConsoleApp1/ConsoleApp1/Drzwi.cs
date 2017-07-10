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
      Stan = "Zamkniête";
    }
  }
}