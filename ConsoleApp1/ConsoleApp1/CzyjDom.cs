using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class CzyjDom
  {
    private string Czyj;
    public CzyjDom()
    {
      Standardowy();
    }
    public void Jasia()
    {
      Czyj = "Jasia";
    }
    public void Ani()
    {
      Czyj = "Ani";
    }
    public void Standardowy()
    {
      Czyj = "standardowy";
    }
    public string pobierzWlasciciela()
    {
      return Czyj;
    }
  }
}
