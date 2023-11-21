using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._43
{
    internal class Sinif
    {

        public double sayi1;
        public double sayi2;


        public double topla;
        public double cikar;
        public double carp;
        public double bol;

        public double Toplama()
        {
            return sayi1 + sayi2;

        }
        public double Cikarma()
        {
            return sayi1 - sayi2;
        }
        public double Carpma()
        {
            return sayi1 * sayi2;
        }
        public double Bol()
        {
            return sayi2 / sayi2;
        }

        
           
    }
}
