using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunitTest
{
    [TestFixture] // bu ifade bize bu sınıfın bir test sınıfı olduğunu ifade etmektedir
    public class mathTest //testSınıfımız
    {
        Math m = new Math(); // burada math sınıfımızdan bir nesne oluşturduk

        [Test] //bu ifade bize bu metodun test metodu olduğunu ifade etmektedir
        public void toplama() //toplama test metodumuz
        {
            double sonuc = m.toplama(3, 5); //toplama methoduna sayılarımızı parametre olarak geçirdik, ve math sınıfının metodunu çağırdık
            Assert.AreEqual(8, sonuc); // burada olması gereken ilk parametre geçirilir, sonra geri dönen sonuç parametre geçirilir
        }

        [Test]
        public void cikartma() //cikartma test metodumuz
        {
            double sonuc = m.cikartma(3, 5);//çikartma metoduna sayılarımızı parametre olarak geçirdik

            Assert.AreEqual(-2, sonuc);// burada olması gereken ilk parametre geçirilir, sonra geri dönen sonuç parametre geçirilir
        }

        [Test]
        public void bolme() //bolme test metodumuz
        {
            double sonuc = m.bolme(3, 5);//bölme metoduna sayılarımızı parametre olarak geçirdik
            Assert.AreEqual(0.6, sonuc);// burada olması gereken ilk parametre geçirilir, sonra geri dönen sonuç parametre geçirilir
        }

        [Test]
        public void usAlma()//usAlma test metodumuz
        {
            
           
           double sonuc= m.usAlma(2, 3);//usAlma metoduna sayılarımızı parametre olarak geçirdik

            Assert.AreEqual(8,sonuc );// burada olması gereken ilk parametre geçirilir, sonra geri dönen sonuç parametre geçirilir
        }
    }
}
