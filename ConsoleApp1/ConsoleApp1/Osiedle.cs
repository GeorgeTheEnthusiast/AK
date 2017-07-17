using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal class Osiedle
  {
    public List<Dom> _dom = new List<Dom>();
    public string NazwaOsiedla;
    public string NazwaUlicy;
		public Dom DomyOsiedla = new Dom();

    public Osiedle(string nazwaOsiedla, string nazwaUlicy)
    {
      NazwaOsiedla = nazwaOsiedla;
      NazwaUlicy = nazwaUlicy;
    }

		public void ListaDomow()
		{
			_dom.Add(DomyOsiedla);
			_dom.Add(DomyOsiedla);
			_dom.Add(DomyOsiedla);
		}



  }
}
