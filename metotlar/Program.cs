using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            // METOTLAR 

            /* METOTLAR SINIFIN İÇİNDE TANIMLANMALIDIR, METOT İÇİNDE METOT TANIMLANAMAZ!
             * STATIC BİR METOD İÇİNDEN ANCAK YİNE STATIC BİR METOT ÇAĞRILABİLİR!
             */
            //int x = 3, y = 5;
            //Yaz(Toplama_metodu(x,y, 5,6,12));
            //Console.WriteLine(Toplama_metodu(x, y));

            ////metotlar iç içe kullanılabilir.
            //Yaz(Toplama_metodu(x,y));

            //Yaz(Get_AccountName(x));

            ////varsayılan değerli parametre kullanımı
            //KullanıcıEkle("Regaip", "Kurt");
            ////PARAMETRELER İSİMLERİYLE DE KULLANILABİLİR!
            //KullanıcıEkle(ad:"Kemal", soyad:"KARA", durum:false);

            ////Aynı isimde farklı parametreler alan birçok metot belirleyebiliriz.
            //// Aldığı parametreye göre uygun olanı çağırır program.
            //// Buna da overload denir. 
            //// Örneğin beklet adında iki metot var ama program hangisi olduğunu anlıyor.
            //Console.WriteLine("1. Beklet Metodu Başladı! 2 Saniye Sürecek...");
            //Beklet(2000);
            //Console.WriteLine("İkinci Beklet Metodu Başladı! Bir tuşa basana kadar bekleyecek!");
            
            Beklet();
        }

        static void KullanıcıEkle(string ad, string soyad, bool durum=true) 
        //varsayılan değerli parametre kullanımı, OPSİYONEL PARAMETRELER SONDA YAZILMAK ZORUNDA!
        {
            string durum2 = durum == false ? "Pasif" : "Aktif";
            Console.Write("Kullanıcı Eklendi ==>\t");
            Console.WriteLine($"Ad: {ad}, Soyad: {soyad}, Durum: {durum2}\n");
        }
        
        static string Get_AccountName(int a) {
            string name = string.Empty;
            switch (a)
            {
                case 1:
                    name = "Ali";
                    break;
                case 2:
                    name = "Kemal";
                    break;
                case 3:
                    name = "Ayşe";
                    break;
                case 4:
                    name = "Beyza";
                    break;
                default:
                    break;
            }
            return name;
        }

        static int Toplama_metodu(params int[] parameters)
        {
            return parameters.Sum();
        } //liste şeklinde de parametreleri toplayabilir.

        static void Yaz(object metin)
        {
            Console.WriteLine(metin);
        }

        static void Beklet() //değer verilmediyse bir tuşa basana kadar bekler.
        {
            Console.ReadLine();
        }

        static void Beklet(int a) //değer verilirse süre kadar bekler.
        {
            System.Threading.Thread.Sleep(a);
        }

    }
}
