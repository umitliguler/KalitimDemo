using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var otomobil = new Otomobil();
            otomobil.Agirlik = 1250;
            otomobil.Marka = "";
            Console.WriteLine("Otomobil.KapiSayisi : {0}", otomobil.KapiSayisi);

            var kamyon = new Kamyon(50);
            kamyon.Hacim = 4000;

            var limuzin = new Limuzin();
            Console.WriteLine("Limuzin.KapiSayisi : {0}", limuzin.KapiSayisi);


            Console.ReadKey();

        }
    }
}
