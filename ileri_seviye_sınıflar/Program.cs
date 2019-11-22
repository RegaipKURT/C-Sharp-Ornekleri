using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {

            //liste liste = new liste();
            liste<string> liste = new liste<string>();
            liste.Add("Tahir");
            liste.Add("Kemal");

            liste.Get();

            Console.ReadLine();
            
        }
    }
    class liste { }
    class liste<T>
    {
        List<T> list = new List<T>();
        public liste()
        {
            Console.WriteLine(typeof(T));

        }
        public void Add(T guccuk_T)
        {
            list.Add(guccuk_T);
        }
        public void Get()
        {
            foreach (var eleman in list)
            {
                Console.Write($"{eleman}\t");
            }
        }

}
}
