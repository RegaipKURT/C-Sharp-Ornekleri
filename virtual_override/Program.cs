using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soyut_nesneler
{
    // virtual ve override birbirini tamamlayan iki keyword'dur.
    // virtual override edilebilir - "yerine yenisi yazılıp kullanılabilir başka bir yerde" demektir.
    // override ise aynı isimdeki metodu burada benim söylediğim şekilde kulllan demektir.
    // Yani tıpkı overloading gibidir. Ama virtual-override keywordleri ile kullanılır.
    class Program
    {
        static void Main(string[] args)
        {
            calisan isci = new calisan();
            double maas_isci = isci.MaasHesapla_base();
            isci.Ad = "Mehmet";
            isci.Soyad = "Alkan";
            Console.WriteLine($"{isci.ToString()}\nMaas: {isci.MaasHesapla_base()}");
            Muhendis muhendis = new Muhendis();
            muhendis.Ad = "Dennis";
            muhendis.Soyad = "Ritchie";
            Console.WriteLine($"{muhendis.ToString()}\nMaas: {muhendis.MaasHesapla()}");
            Console.WriteLine(muhendis.MaasHesapla_base());


            Console.ReadLine();
        }
    }
}
