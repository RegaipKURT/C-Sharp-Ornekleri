using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_miras
{
    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //a.PropA = 5;
            //B b = new B();
            //b.PropB = 4;
            //C c = new C();
            //c.PropC = 3;

            //Console.WriteLine("A PropA: "+a.PropA);
            //Console.WriteLine("B PropB: " + b.PropB);
            //Console.WriteLine("C PropA: " + c.PropA);
            //Console.WriteLine("C PropB: " + c.PropB);
            //Console.WriteLine("C PropC: " + c.PropC);
            //c.PropA = 10;
            //c.PropB = 11;
            //Console.WriteLine("C'nin içinden a ve b yi değiştirdikten sonra!");
            //Console.WriteLine("A PropA: " + a.PropA);
            //Console.WriteLine("B PropB: " + b.PropB);
            //Console.WriteLine("C PropA: " + c.PropA);
            //Console.WriteLine("C PropB: " + c.PropB);


            //ikiboyut kare = new ikiboyut();
            ucgen uc = new ucgen
            {

                //kare.genislik = 4; kare.yukseklik = 4;
                //kare.Goster();
                //kare.AlanGoster();

                genislik = 5,
                yukseklik = 10
            };
            uc.Goster();
            double alan = uc.AlanHesapla();
            Console.WriteLine("Alan = " + alan);

            Console.ReadLine();
        }
    }
    class A {
        public int PropA { get; set; }
    }

    class B : A
    {
        public int PropB { get; set; }
    }

    class C : B {
        public int PropC { get; set; }
    }
}
