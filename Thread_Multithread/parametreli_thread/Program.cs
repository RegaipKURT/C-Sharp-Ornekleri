using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parametreli_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            AddParams ap = new AddParams(20, 10);
            Thread t = new Thread(new ParameterizedThreadStart(Add));
            t.Start(ap);

            Console.ReadLine();

        }
        static void Add(object data)
        {
            if (data is AddParams)
            {
                Console.WriteLine("Id of thread main(): {0}", Thread.CurrentThread.ManagedThreadId);
                AddParams ap = (AddParams)data;
                Console.WriteLine("{0} + {1} = {2}", ap.a, ap.b, ap.a + ap.b);
            }
        }
    }
    class AddParams
    {
        public int a;
        public int b;

        public AddParams(int x, int y) { a = x; b = y; }
    }
}
