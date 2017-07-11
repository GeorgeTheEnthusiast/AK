namespace ConsoleApp1
{
  class Drzwi
  {

    public string Material = "drewno";
    public string Kolor = "orzech";
    private string Stan;



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