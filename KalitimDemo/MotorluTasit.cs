using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimDemo
{
    public class MotorluTasit
    {
        public MotorluTasit()
        {
            Console.WriteLine("MotoluTasit contr. çalıştı");
        }

        public MotorluTasit(int val)
        {
            Console.WriteLine("MotorluTasit : {0}", val);
        }
         
        public float Agirlik { get; set; }
        public int Hacim { get; set; }
        public int DepoHacmi { get; set; }
    }
}
