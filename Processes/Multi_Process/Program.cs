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
            
            Dosya_Yaz("arguman_dosyasi.txt", "4\n6\n9\n6");
            Console.WriteLine("Yazma İşlemi Yapılıyor...");

            Process py_islemi = Process.Start("test.py");
            py_islemi.WaitForExit();
            Console.WriteLine("Python İşemi Bitti!");
            object sonuc = Dosya_Oku("sonuc_dosyasi.txt");
            Console.WriteLine("Sonuc: " + sonuc);
            Console.ReadLine();
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
