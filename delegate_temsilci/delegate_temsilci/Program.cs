using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_temsilci
{
    class Program
    {
        static void Main(string[] args)
        {
            //DELEGATE - TEMSİLCİ

            /* Bir temsilci birden fazla metodu temsil eden bir öenektir.
             * Fakat temsil ettiği örneklerin parametre tipleri ile geri dönüş tipi temsilci ile aynı olmadılıdır.
             * Yani temsil ettiği metodun imzasını karşılayabilmelidir.
             */

            ////Hesap hesap = new Hesap(Topla); // bu da diğer kurulum yöntemi
            //Hesap hesap;
            //hesap = Topla;
            //Console.WriteLine("Topla :" + hesap(5, 4));
            //hesap = Carp;
            //Console.WriteLine("Çarpım :" + hesap.Invoke(5, 4));//bir özellikmiş gibi de kullanılabilir.
            //hesap = Cıkar;
            //Console.WriteLine("Fark :" + hesap(5, 4));

            ////bol kısmında ise hata verecek çünkü bölümün geri dönüş tipi int değil decimal.
            ////ama bizim hesap delegetimiz int geri dönüş tipine sahip
            //hesap = Bol; //wrong return type yazacaktır.
            //Console.WriteLine("Bolum :" + hesap(5, 4));

            // GENERİC DELEGATE

            GenDel<string> buyut = new GenDel<string>(Metin_Buyut);
            buyut.Invoke("regaip kurt");
            GenDel<int> artır = new GenDel<int>(Artır);
            artır(9);
            

            Console.ReadLine();
        }

        delegate void GenDel<T>(T arg);

        delegate int Hesap(int x, int y);

        static int Topla(int a, int b)
        {
            return a + b;
        }

        static int Cıkar(int a, int b)
        {
            return a - b;
        }

        static int Carp(int a, int b)
        {
            return a * b;
        }

        static double Bol(int a, int b)
        {
            return a / b;
        }

        static void Metin_Buyut(string arg)
        {
            Console.WriteLine("Büyük: " + arg.ToUpper());
        }

        static void Artır(int sayi) { Console.WriteLine("Artırılmış: " + ++sayi); }
    }
}
