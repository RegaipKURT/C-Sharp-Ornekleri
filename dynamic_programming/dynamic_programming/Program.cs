using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            //dynamic a = 5;
            //Console.WriteLine(a);
            //a = "AA";
            //Console.WriteLine(a.GetType());

            //dynamic insan = new ExpandoObject();
            //insan.Ad = "Regaip";
            //insan.Soyad = "KURT";
            //Console.WriteLine(insan.Ad);
            //Console.WriteLine(insan.GetType());


            dynamic kisi = new ExpandoObject();
            kisi.Ad = "Regaip";
            kisi.Soyad = "Kurt";
            kisi.AdGoster = new Action(() => { Console.WriteLine("Ad: " + kisi.Ad); });
            kisi.AdGoster();

            kisi.tekrarla = new Func<string, string>(x => { return x; } );
            dynamic a = kisi.tekrarla(kisi.Soyad);
            Console.WriteLine("Dönen Değer: " + a);


            Console.ReadLine();
        }
    }
    class kemal { }
}
