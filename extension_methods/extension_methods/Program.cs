using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //extension methods
            // extension methods kullanabilemek için içine alınan parametre this diye tipiyle beraber berlirtilmeli
            // ayrıca hem extension için kullanılan sınıf hem de metot public ve static olmalı.
            // static olmalı çünkü nesne örneği üretmeden kullanılıyor.

            object obj1 = new object();
            obj1 = new Program();

            obj1.DisAssembly();

            int a = 500;
            Console.WriteLine(a.Kare());

            // terscevir ve terscevirgoster extensionlarımızı kullanalım
            string kelimem = "deli baysal";
            kelimem.TersCevirGoster();
            Console.WriteLine(kelimem.TersCevirAl());


            //şimdi de iterable nesneler için elemanları gösterme extension metodumuzu kullanalım
            List<int> sayılar = new List<int>() { 1,2,3,4,5,6,7,8,9};

            sayılar.ShowItems();


            Console.ReadLine();
        }
    }
}
