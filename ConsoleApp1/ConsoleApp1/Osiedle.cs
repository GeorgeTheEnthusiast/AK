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
		public Dom DomyOsiedla;

    public Osiedle(string nazwaOsiedla, string nazwaUlicy)
    {
      NazwaOsiedla = nazwaOsiedla;
      NazwaUlicy = nazwaUlicy;
    }

		public void ListaDomow()
		{

			for (int i = 0; i < 3; i++)
			{
				_dom.Add(DomyOsiedla);
			}

		}



  }
}
