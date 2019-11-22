using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_keywordu
{
    class Program
    {
        static void Main(string[] args)
        {
            // static katı, ayrık, tek başına kullanılan gibi düşünebiliriz.
            //static demek; çalışmak için nesne örneğine ihtiyaç duymayan ve hatta nesne örneği üretilmesine
            // müsade edilmeyen demektir.
            // Yani bir metot veya sınıf static yapılırsa nesne örneği üretilmeden kullanılır.
            // Eğer static olan şey, bir sınıfa ait metotsa sadece sınıf örneği yoksa o metot kullanılabilir.
            // Eğer sınıfın kendisi static olarak belirlenmişse o sınıfın örneği üretilemez.
            // Örneğin sifreleme isimli bir sınıf yapıp sadece özellkilerini static yapalım.

            //sifreleme enc = new sifreleme();
            // örneğin static metotlarımızı burada göremeyeceğiz. çünkü statik metotlar sınıf örneğiyle kullanılmaz.
            //ama normal şekilde kullanabiliriz.
            sifreleme.sifrele("hoşgeldiniz");
            Console.ReadLine();
            
            // eğer sınıfımız statik olsaydı onun da nesne örneğini üretemezdik.
            // sifreleme class'ının isminin başına static koyarsak örnek üretilemez.

        }
    }
}
