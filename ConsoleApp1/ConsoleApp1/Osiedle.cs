using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal class Osiedle
  {
    public List<Dom> _listaDomow = new List<Dom>();
		public string NazwaOsiedla;
    public string NazwaUlicy;

    public Osiedle(string nazwaOsiedla, string nazwaUlicy)
    {
      NazwaOsiedla = nazwaOsiedla;
      NazwaUlicy = nazwaUlicy;
			DodanieDomowDoOsiedla();
    }

		public void DodanieDomowDoOsiedla()
		{
			Dom dom1 = new Dom("Ani");
			Dom dom2 = new Dom("Grzesia");
			Dom dom3 = new Dom("Jasia");
		
			_listaDomow.Add(dom1);
			_listaDomow.Add(dom2);
			_listaDomow.Add(dom3);
		}

		public void WydrukujWlascicieliDomow()
		{
			Console.WriteLine(string.Format("Osiedle {0}, posiada domy:", NazwaOsiedla));

			String imieWlasciciela;
			foreach (Dom dom in _listaDomow)
			{
				imieWlasciciela = dom.Wlasciciel;
				Console.WriteLine(string.Format("{0}", imieWlasciciela));
			}
			/*for (int i = 0; i < _listaDomow.Count; i++)
			{
				imieWlasciciela = _listaDomow[i].Kogo.pobierzWlasciciela();
				Console.WriteLine(string.Format("{0}", imieWlasciciela));
			}*/
			
		}
		public void WydrukujStanOsiedla()
		{
			System.Console.WriteLine(string.Format("Osiedle {0} tworzą {1} domy.", NazwaOsiedla, _listaDomow.Count));
			Console.WriteLine(string.Format("Dom ma sciany w kolorze: {0}, a dach: {1}", Dom.ZmienKolorScianDomu.Szary, Dom.ZmienKolorDachuDomu.Zielony));
			Console.WriteLine(string.Format("Drzwi domów są w kolorze: {0}, materiał z jakiego są wykonane to: {1}", Drzwi.ZmienKolorDrzwi.Orzech, Drzwi.ZmienMaterialDrzwi.Drewno));
		}
  }
}
