using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nunitTest
{
   public  class Math // test edilecek sınıfımız
    {
        
        public int toplama(int a , int b) //toplama methodumuz
        {
            return a + b;
        }

        public int cikartma(int a, int b) // cikartma methodumuz
        {
            return a - b;
        }

        public double bolme(double a,double b) // bölme methodumuz
        {
            return a /b;

        }
        
        double sonuc = 1;
        public double usAlma(double sayi,double us) // üst alma methodumuz
        {
            
            for (int i=1; i <= us; i++)
            {
                sonuc = sonuc * sayi;
                
            }

            return sonuc;
        }
    }
}
