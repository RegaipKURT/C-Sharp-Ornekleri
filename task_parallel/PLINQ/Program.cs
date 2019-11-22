using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // PARALLEL LINQ

            Int64[] data = new Int64[100000000];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }

            data[1000] = -1;
            data[4584] = -2;
            data[45646] = -3;
            data[456485] = -4;
            data[41564861] = -5;
            data[456462] = -6;
            data[99254789] = -7;
            data[256487] = -8;
            data[9874226] = -9;
            data[36971] = -10;
            data[12387933] = -11;
            data[99999999] = -12;

            //normal sorgu
            DateTime baslangic =  DateTime.Now;

            var result = from val in data where val < 0 select val;

            

            foreach (int res in result)
            {
                Console.WriteLine(res);
            }

            DateTime sonlanma = DateTime.Now;

            Console.WriteLine(sonlanma - baslangic);

            //100 milyon elemanlı bir dizi oluşturduk ve içinde bazı negatig değerler var.

            //paralel sorgu.
            var result2 = from val in data.AsParallel().AsOrdered() where val < 0 select val;

            baslangic = DateTime.Now;
            
            foreach (int res2 in result2)
            {
                Console.WriteLine(res2);
            }

            sonlanma = DateTime.Now;
            Console.WriteLine(sonlanma - baslangic);

            Console.ReadLine();
        }
    }
}
