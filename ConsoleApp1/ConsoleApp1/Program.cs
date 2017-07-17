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
      Dom standardowyDom = new Dom();
      Dom domJasia = new Dom();
      Dom domAni = new Dom();
			Osiedle Zielone = new Osiedle("Zielone", "Lipska");
			Osiedle Ustronie = new Osiedle("Ustronie", "Kasztanowa");
			Osiedle Kmicica = new Osiedle("Kmicica", "Działkowa");
			Console.WriteLine(string.Format("Osiedla {0}, {1}, {2}", Ustronie.NazwaOsiedla, Kmicica.NazwaOsiedla, Zielone.NazwaOsiedla));


      /*standardowyDom.WydrukujStanDomu();
      domJasia.Kogo.Jasia();
      domJasia.WydrukujStanDomu();
      domAni.Kogo.Ani();
      domAni.WydrukujStanDomu();



      domJasia.OknoDomu.Szerokosc = 1.7;
      domAni.KolorScian = "niebieski";
      domAni.DrzwiDomu.Otworz();

      domJasia.WydrukujStanDomu();
      domAni.WydrukujStanDomu();*/



      Console.ReadLine();
    }
  }
}
