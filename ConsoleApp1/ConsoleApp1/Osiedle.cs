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
			Dom dom1 = new Dom();
			Dom dom2 = new Dom();
			Dom dom3 = new Dom();
			_listaDomow.Add(dom1);
			_listaDomow.Add(dom2);
			_listaDomow.Add(dom3);
		}

		public void WydrukujStanOsiedla()
		{
			System.Console.WriteLine(string.Format("Osiedle {0}, które tworzą {1} domy.", NazwaOsiedla, _listaDomow.Count));
		}
  }
}
