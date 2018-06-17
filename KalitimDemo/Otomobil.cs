using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimDemo
{
    public class Otomobil : MotorluTasit
    {
        public string Marka { get; set; }

        public virtual int KapiSayisi
        {
            get { return 4; }
        }
         
    }
}
