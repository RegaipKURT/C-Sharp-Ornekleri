using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Invoke
{
    class Program
    {
        static void Main()
        {
            // Parallel.Invoke() içine birden fazla metot alarak bunları paralel şekilde çalıştırır.

            Parallel.Invoke(myt1, myt2);

            Console.ReadLine();

        }

        static void myt1()
        {
            Console.WriteLine("1. paralel işlem başladı");

            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(200);
                Console.WriteLine("1. paralel sayıyor: " + i);
            }

            Console.WriteLine("1. paralel işlem bitti");
        }

        static void myt2()
        {
            Console.WriteLine("2. paralel işlem başladı");

            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(200);
                Console.WriteLine("2. paralel sayıyor: " + i);
            }

            Console.WriteLine("2. paralel işlem bitti");
        }
    }
}
