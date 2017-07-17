using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Osiedle
  {
    public List<Dom> _dom = new List<Dom>();
    public string NazwaOsiedla;
    public string NazwaUlicy;

    public Osiedle(string nazwaOsiedla, string nazwaUlicy)
    { 
      NazwaOsiedla = nazwaOsiedla;
      NazwaUlicy = nazwaUlicy;
    }
  }
}
