using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // SEALED CLASS - MÜHÜRLÜ SINIF

            B b = new B();
            b.PropB = 1;
            b.PropA = 3;

            // fakat B sınıfının başına sealed keywordu koyarsak hiç bir sınıf B'dEn miras alamaz.
            // Örnekte B sınıfının başına sealed koyup C sınıfında deneyelim.

            C c = new C();
            c.PropC = 5;
            c.PropA = 7;
            //c.PropB = 9; // B'yi miras almasını deneyip hatayı gÖrebiliriz.
            
            Console.ReadLine();
        }
    }

    class A { public int PropA { get; set; }}
    sealed class B : A { public int PropB { get; set; }}
    class C : A { public int PropC { get; set; } }
}
