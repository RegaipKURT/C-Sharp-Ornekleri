using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasorIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasorOlustur("yeni klasör");
            KlasorBilgi("yeni klasör");
            KlasorKontrol("yeni klasör");
            KlasorSil("yeni klasör");
            KlasorKontrol("yeni klasör");

            Console.ReadLine();

        }

        public static void KlasorOlustur(string klasoradi)
        {
            Directory.CreateDirectory(klasoradi);
            //Programın çalıştığı dizine YeniKlasör isimli bir klasör oluşturur.
            //Directory.CreateDirectory(@"C:\YeniKlasör");
            //C: dizini altına YeniKlasör isminde bir klasör oluşturur.
        }

        public static void KlasorSil(string klasoradi)
        {
            //Delete metodu ile klasör silme:
            Directory.Delete(klasoradi);
            //verilen dizin ve isimdeki klasörü siler.
        }
        public static void KlasorBilgi(string klasoradi)
        {
            // Klasör hakkında detaylı bilgi edinme

            DateTime olusturmaZamani = Directory.GetCreationTime(klasoradi);
            Console.WriteLine(olusturmaZamani.ToString());
            //Belirtilen klasörün oluşturulduğu tarih ve zamanı gösterir.
            DateTime sonErisimZamani = Directory.GetLastAccessTime(klasoradi);
            Console.WriteLine(sonErisimZamani.ToString());
            //Klasöre en son erişim sağlandığı zamanın bilgisini döndürür.
            DateTime sonYazimZamani = Directory.GetLastWriteTime(klasoradi);
            Console.WriteLine(sonYazimZamani.ToString());
            //Klasöre en son veri yazıldığı zamanın bilgisini döndürür.
        }
        public static void KlasorTaşı(string klasoradi, string tasıma_yeri)
        {
            //Move metodu ile klasörü taşıma
            Directory.Move(klasoradi, tasıma_yeri);
            //Klasörü birinci parametredeki dizinden alıp, ikinci parametredeki dizine taşır.
        }
        public static void KlasorKontrol(string klasoradi)
        {
            //Exist metodu ile klasörün varlığını kontrol etme
            if (Directory.Exists(@klasoradi))
                Console.WriteLine("Evet var");
            else
                Console.WriteLine("Hayır yok");
        }
    }
}