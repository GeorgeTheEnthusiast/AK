namespace ConsoleApp1
{
  class Drzwi
  {
    public string Material;
    public string Kolor;
    private string Stan;

    public void Otworz()
    {
      Stan = "Otwarte";
    }

    public void Zamknij()
    {
      Stan = "Zamkni�te";
    }
		public string pobierzStan()
		{
			return Stan;
		}
  }
}