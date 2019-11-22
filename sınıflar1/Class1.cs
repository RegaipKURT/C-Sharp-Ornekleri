using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflar1
{
    class Class1
    {
        public static void Metod(string[] args)
        {
            A sinif1 = new A();
            A.B sinif2 = new A.B();
            Console.ReadLine();
        }
        
    }

    class A
    {
        public int PropA { get; set; }
        public A ()
        {
            Console.WriteLine("Constructor A");
        }
        public class B // public olmazsa A.B oluşturulamaz!
        {
            public int PropB { get; set; }
            public B()
            {
                Console.WriteLine("Constructor B");
            }
        }
    }

}
