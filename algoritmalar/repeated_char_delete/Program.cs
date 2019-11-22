using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeated_char_delete
{
    class Program
    {
        static void Main(string[] args)
        {
            string ns = Tekrarlılarısil("merhabaalar!!!");


            Console.WriteLine(ns);

            Console.ReadLine();
        }

        static string Tekrarlılarısil(string x)
        {
             
            string ns = "";
            string a = ""; ;
            for (int i = 1; i < x.Length; i++)
            {
                a = x[i].ToString();
                if (ns.IndexOf(a) == -1)
                {
                    ns += a;
                }
            }

            return ns;
        }
    }
}
