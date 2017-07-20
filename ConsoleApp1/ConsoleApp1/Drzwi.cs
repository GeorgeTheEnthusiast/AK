namespace ConsoleApp1
{
  public class Drzwi
  {
    private string Stan;

		public Drzwi()
    {
      Zamknij();
    }

		public enum ZmienMaterialDrzwi
		{
			Drewno,
			Stal
		}

		public enum ZmienKolorDrzwi
		{
			Orzech,
			Dab,
			Sosna,
			Wenge
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