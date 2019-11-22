using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poliymorphysm
{
    class Program
    {
        static void Main(string[] args)
        {

            //bütün mesele farklı sınıflardan oluşan ürünleri sepete nasıl ekleriz?
            // çünkü basket.add metodu içine bir öğe alıp listeye eklemek zorunda ama ürünlerin sınıflar farklı
            // fakat hepsi product sınıfından miras aldıkları için tipini product olarak belirtip ekleyebiliriz.
            // işte çok biçimlilik bir sınıfın miras aldığı sınıf gibi davranabilmesidir.
            // bizim örneğimizde  bir metodun içine product nesne vererek bütün sınıfları almasını sağlayabiliyoruz.

            Basket sepet = new Basket();

            Bread ekmek = new Bread();

            Tekstil ceket = new Tekstil();

            Product yeni = new Product();

            ekmek.Price = 10;
            ceket.Price = 150;
            yeni.Price = 35.4;

            sepet.Add(ekmek);
            sepet.Add(ceket);
            sepet.Add(yeni);

            sepet.ToplamFiyat();

            Console.WriteLine("Bitti!");
            Console.ReadLine();

        }
    }
}
