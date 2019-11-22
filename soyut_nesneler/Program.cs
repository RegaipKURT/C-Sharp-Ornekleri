using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soyut_nesneler
{
    // ABSTRACT CLASSES - SOYUT NESNELER
    /// <AÇIKLAMA>
    ///  ABSTRACT CLASS VEYA METOTLAR OVERRİDE YAPMAYI ZORUNLU KILARLAR.
    ///  ÖRNEĞİN HER SINIFIN KENDİ İÇİNDE BELİRLENMESİNİ İSTEDİĞİMİZ BİR METODUMUZ VARSA BİZ SADECE METODU 
    ///  GÖVDESİ OLMADAN YAZAR VE BAŞINA ABSTRACT KOYARIZ (CLASS DA ABSTARACT OLMAK ZORUNDA). DAHA SONRA
    ///  O SINIFIN BİR ÖRNEĞİ OLUŞTURULDUĞUNDA O METOD ÖRNEK İÇİNDE VEYA KALITIM ALAN YERDE DÜZENLENMEK ZORUNDA
    ///  OLUR. AKSİ TAKDİRDE PROGRAM HATA VERİR. YANİ OVERRİDE YAPMAYI ZORUNLU KILMIŞ OLURUZ.
    ///  BUNUN İÇİN DE OVERRİDE KULLANILIR AMA SADECE VİRTUAL YERİNE ABSTRACT DEMİŞ OLURUZ.
    /// </AÇIKLAMA>
    class Program
    {
        static void Main(string[] args)
        {
            Isci isci = new Isci();
            double maas_isci = isci.MaasHesapla();
            isci.Ad = "Mehmet";
            isci.Soyad = "Alkan";
            Console.WriteLine($"{isci.ToString()}\nMaas: {isci.MaasHesapla()}");
            Muhendis muhendis = new Muhendis();
            muhendis.Ad = "Dennis";
            muhendis.Soyad = "Ritchie";
            Console.WriteLine($"{muhendis.ToString()}\nMaas: {muhendis.MaasHesapla()}");
            Console.WriteLine(muhendis.MaasHesapla());


            Console.ReadLine();
        }
    }
}
