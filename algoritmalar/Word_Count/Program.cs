using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {

            int kelimesay = CountTheWords("kelime sayısını bulmak istiyorum!");
            Console.WriteLine("Kelime sayısı: " + kelimesay);
            Console.ReadLine();
        }

        static int CountTheWords(string data)
        {

            data = data.Trim(); // metnin sağ ve solundaki boşlukları siler


            while (data.Contains("  "))
            {
                data.Replace("  ", " ");
            }

            if (data=="")
            {
                return 0;
            }
            char[] veri = data.ToCharArray();
            int kelime_sayısı = 1;
            for (int i = 0; i < veri.Length-1; i++)
            {
                if (veri[i].ToString() == " ")
                {
                    kelime_sayısı += 1;
                }

            }

            return kelime_sayısı;
        }
    }

    
}
