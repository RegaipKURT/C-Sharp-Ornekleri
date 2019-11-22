using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagram_kontrol
{
    class Program
    {
        static void Main(string[] args)
        {

            // Anagram: iki kelime farklı olduğu halde aynı harflerden oluşuyorsa, buna anagramlık denir.

            Console.WriteLine(Anagram_Kontrol("tarak", "TARAK"));

            Console.ReadLine();

        }

        static bool Anagram_Kontrol(string kelime1, string kelime2)
        {
            kelime1 = kelime1.ToLower();
            kelime2 = kelime2.ToLower();

            int uzunluk1 = kelime1.Length;
            int uzunluk2 = kelime2.Length;


            

            if (kelime1 == kelime2)
            {
                Console.WriteLine("Kelimeler aynıydı!");
                return false;
            }

            else
            {
                if (uzunluk1 > uzunluk2)
                {
                    for (int i = 0; i < uzunluk2; i++)
                    {
                        if (kelime2.IndexOf(kelime1[i]) == -1)
                        {
                            return false;
                        }
                    }
                }

                else if (uzunluk2 >= uzunluk1)
                {
                    for (int i = 0; i < uzunluk1; i++)
                    {
                        if (kelime1.IndexOf(kelime2[i]) == -1)
                        {
                            return false;
                        }
                    }
                }
            }
            

            return true;
        }
    }
}
