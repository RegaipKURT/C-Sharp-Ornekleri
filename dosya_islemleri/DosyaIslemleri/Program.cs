using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosya_okuma_yazma
{
    class Program
    {
        static void Main(string[] args)
        {
            DosyayaYaz("new.txt"); //default olarak bin/debug içinde işlem yapar
            DosyadanOku("new.txt");
            Console.WriteLine(DosyaKontrol("new.txt"));
            DosyaSil("new.txt");
            Console.WriteLine(DosyaKontrol("new.txt"));


            Console.ReadLine();
        }
        private static void DosyayaYaz(string dosya)
        {
            string dosya_yolu = dosya;
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            sw.WriteLine("1. satır: merhaba");
            sw.WriteLine("2. satır: dünya");
            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }
        public static void DosyadanOku(string dosya)
        {
            string dosya_yolu = dosya;
            //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                Console.WriteLine(yazi);
                yazi = sw.ReadLine();
            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }

        public static string DosyaKontrol(string dosyaadi)
        {
            if (File.Exists(dosyaadi)) { return "Dosya bulundu."; }

            else { return "Dosya mevcut değil."; }
                
        }

        public static void DosyaSil(string dosyaadi)
        {
            File.Delete(dosyaadi);
            //Belirtilen dosyayı siler.
        }
        public static void DosyaTasi(string dosyaadi, string tasimayolu)
        {
            File.Move(dosyaadi, tasimayolu);
            //1.parametrede adı geçen dosya, ikinci parametrede belirtilen adrese taşınır.
        }

        public static void DosyaKopyala(string dosyaadi, string kopyalamayolu)
        {
            File.Copy(dosyaadi, kopyalamayolu);
            //1.parametrede adı geçen dosya, ikinci parametrede belirtilen adrese kopyalanır.
        }

    }
}
