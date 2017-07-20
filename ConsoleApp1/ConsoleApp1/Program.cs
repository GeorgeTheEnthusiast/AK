using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      //Dom standardowyDom = new Dom("Standardowy");
     /* Dom domJasia = new Dom();*/
     // Dom domAni = new Dom();
			Osiedle osiedleZielone = new Osiedle("Zielone", "Lipska");
			Osiedle osiedleUstronie = new Osiedle("Ustronie", "Kasztanowa");
			Osiedle osiedleKmicica = new Osiedle("Kmicica", "Działkowa");

				osiedleKmicica.WydrukujStanOsiedla();
				osiedleKmicica.WydrukujWlascicieliDomow();
		//	standardowyDom.WydrukujStanDomu();
	
      Console.ReadLine();
    }
  }
}
