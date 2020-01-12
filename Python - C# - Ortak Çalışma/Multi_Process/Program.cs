using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Multi_Process
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                { "neig", "5" },
                { "random_state", "None" },
                { "size_test", "0.1" },
                { "model", "1"}
            };

            Parametre_Yaz(dict, "parametreler.log");
            
            Console.WriteLine("Yazma İşlemi Yapılıyor...");
            
            Process py_islemi = Process.Start("deneme.py");
            py_islemi.WaitForExit();
            Console.WriteLine("Python İşlemi Bitti!");
            object sonuc = Dosya_Oku("arguman_dosyasi.txt");
            Console.WriteLine("Parametreler: " + sonuc);
            
            Console.ReadLine();
        }

        static void Parametre_Yaz(Dictionary<string, string> dict, string dosya_yolu)
        {
            string deger = "{";
            for (int i = 0; i < dict.Count; i++)
            {
                
                if (i == dict.Count - 1 )
                {
                    deger = deger + "'" + dict.Keys.ElementAt(i).ToString()  + "'" + ":"
                                + dict[dict.Keys.ElementAt(i)].ToString() + "}";
                    File.WriteAllText(dosya_yolu, deger);

                }
                else
	            {
                    deger = deger + "'" + dict.Keys.ElementAt(i).ToString() + "'" + ":"
                                + dict[dict.Keys.ElementAt(i)].ToString() + ",";
                    File.WriteAllText(dosya_yolu, deger);
                }
            }
        }

        static void Dosya_Yaz(string dosya_yolu_adi, string metin)
        {
            File.WriteAllText(dosya_yolu_adi, metin);
        }

        static object Dosya_Oku(string dosya_yolu_adi)
        {
            object deger =  File.ReadAllText(dosya_yolu_adi);
            return deger;
        }
    }
}
