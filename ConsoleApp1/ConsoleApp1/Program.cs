using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
	{

		static void Main(string[] args)
		{

			Dom standardowyDom= new Dom();
			Dom domJasia = new Dom();
			Dom domAni = new Dom();


			standardowyDom.WydrukujStanDomu();
			domJasia.Kogo.Jasia();
			domJasia.WydrukujStanDomu();
			domAni.Kogo.Ani();
			domAni.WydrukujStanDomu();
			


			domJasia.OknoDomu.Szerokosc = 1.7;
			domAni.KolorScian = "niebieski";
			domAni.DrzwiDomu.Otworz();

			domJasia.WydrukujStanDomu();
			domAni.WydrukujStanDomu();
			


			Console.ReadLine();

		}
	}
}
