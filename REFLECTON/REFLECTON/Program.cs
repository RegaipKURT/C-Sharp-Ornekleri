using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace REFLECTON
{
    class Program
    {
        static void Main(string[] args)
        {
            /* REFLECTİON NEDİR?
             * REFLECTION BİZE HAKKINDA BİLGİ SAHİBİ OLMADIĞIMIZ NESNELERLE İLGİLİ 
             * ÇALIŞMA ESNASINDA BİLGİ ALMAYI SAĞLAR.
             * ÖRNEĞİN PROGRAMIN ÇALIŞIRKEN İÇİNE BİR DLL EKLEYEREK İÇİNDEKİ METOTLARI VE DIŞARIYA 
             * AÇIK ÖZELLİKLERİ KULLANABİLİRİZ!
            */


            //string path = @"C:\Windows\Microsoft.NET\Framework64\v2.0.50727\System.dll"; //@ özel dizelerden kaçış için
            //Assembly asm = Assembly.LoadFile(path);

            //AssemblyBilgiGoster(asm);

            //Assembly ourasm = Assembly.GetExecutingAssembly();
            //AssemblyBilgiGoster(ourasm);


            var ogrenci = new Ogrenci() {Ad="Kemal", Soyad="Gözler" };

            Type OgrenciTip = typeof(Ogrenci);

            FieldInfo[] OgrenciAlanlar = OgrenciTip.GetFields(BindingFlags.Public|BindingFlags.Instance);

            foreach (FieldInfo OgrenciAlan in OgrenciAlanlar)
            {
                Console.WriteLine("Alan: " + OgrenciAlan.Name);
                Console.WriteLine("Değer: " + OgrenciAlan.GetValue(ogrenci));
                Console.WriteLine("-------------------------");
            }

            Console.ReadLine();
        }
        static void AssemblyBilgiGoster(Assembly asm) //system.reflection ı dahil etmek gerekiyor
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(asm.FullName);
            Console.WriteLine("GAC'da mı: " + (asm.GlobalAssemblyCache ? "Evet" : "Hayır"));
            Console.WriteLine("Path: " + asm.Location);
            Console.WriteLine("Versiyon: " + asm.ImageRuntimeVersion);
            Console.WriteLine("İzin Seti: " + asm.PermissionSet);
        }
    }

    public class Ogrenci
        {
        public string Ad;
        public string Soyad;
        string email;
        }
}
