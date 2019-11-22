using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> Ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci{Id=1, Ad="Kemal", Soyad="Gözler", Dogum_Tarihi = new DateTime(1991,2,14) },
                new Ogrenci{Id=2, Ad="halis", Soyad="demir", Dogum_Tarihi = new DateTime(1991,12,14) },
                new Ogrenci{Id=3, Ad="ayşe", Soyad="türk", Dogum_Tarihi = new DateTime(1994,1,14) },
                new Ogrenci{Id=4, Ad="zeynep", Soyad="aliye", Dogum_Tarihi = new DateTime(1992,1,14) },
                new Ogrenci{Id=5, Ad="regaip", Soyad="kurt", Dogum_Tarihi = new DateTime(1993,1,14) },
                new Ogrenci{Id=6, Ad="ishak", Soyad="temel", Dogum_Tarihi = new DateTime(1990,1,14) },
                new Ogrenci{Id=7, Ad="ismail", Soyad="yılmaz", Dogum_Tarihi = new DateTime(1996,1,14) },
                new Ogrenci{Id=8, Ad="mehmet", Soyad="haklı", Dogum_Tarihi = new DateTime(1991,2,24) },
                new Ogrenci{Id=9, Ad="şamil", Soyad="haktan", Dogum_Tarihi = new DateTime(1991,6,14) },
                new Ogrenci{Id=10, Ad="gazi", Soyad="kayık", Dogum_Tarihi = new DateTime(1994,1,14) },
                new Ogrenci{Id=11, Ad="orhan", Soyad="belleten", Dogum_Tarihi = new DateTime(1993,1,14) },
                new Ogrenci{Id=12, Ad="osman", Soyad="pazarlama", Dogum_Tarihi = new DateTime(1990,11,14) }
            };

            #region //Id'si 4 den büğyük olan öğrenciler 

            // SELECT * FROM Ogrenciler WHERE Id >4; // SQL VERSİYONU BÖYLE OLURDU.

            ////C# İÇİNDE YAPMAK:
            //List<Ogrenci> secilenler = new List<Ogrenci>();

            //foreach (Ogrenci item in Ogrenciler)
            //{
            //    if (item.Id>4)
            //    {
            //        secilenler.Add(item);
            //    }
            //}
            //secilenler.ForEach(i=>Console.WriteLine(i.Ad.ToString() +" "+ i.Soyad.ToString()));

            //Console.ReadLine();

            #endregion


            #region LINQ YONTEMIYLE

            //var sonuc = from x in Ogrenciler
            //            where x.Id > 4
            //            select x;

            //foreach (var item in sonuc)
            //{
            //    Console.WriteLine(item.Ad.ToString() +" " + item.Soyad.ToString());
            //}


            // LINQ İÇİN DE LAMBDA EXPRESSION DA KULLANILABİLİR.
            //var q = Ogrenciler.Where(x => x.Id > 4 && x.Soyad.StartsWith("k"));
            //foreach (var item in q)
            //{
            //    Console.WriteLine(item.Ad.ToString() + " " + item.Soyad.ToString());
            //}


            #endregion


            // ADININ İLK HARFİ M OLAN ÖĞRENCİLER.
            //var q = Ogrenciler.Where(x =>x.Ad.StartsWith("m"));
            //var q = Ogrenciler.Where(x => x.Ad.Substring(0, 1) == "m");

            //Lambda olmadan LINQ ile sorgulama
            //var q = from x in Ogrenciler where x.Ad.StartsWith("r") select x;

            //Yaşı 26 dan büyük olanlar
            //DateTime simdi = DateTime.Today;
            //var q = Ogrenciler.Where(x =>(simdi - x.Dogum_Tarihi).Days/365 > 26); 
            //yukarıdaki daha doğru, alttaki aslında yılı alıp hesaplıyor ve tam dolmamış olabilir.
            //var q = from x in Ogrenciler where DateTime.Now.Year -x.Dogum_Tarihi.Year > 26 select x;

            // salı günü dopan öğrenciler
            //var q = from x in Ogrenciler where x.Dogum_Tarihi.DayOfWeek == DayOfWeek.Tuesday select x;

            //sonucu listeye çevirme 1. yöntem -- DAHA BASİT VE KULLANIŞLI
            //var ogrenciler1 = Ogrenciler.Where(x => x.Dogum_Tarihi.DayOfWeek == DayOfWeek.Friday).ToList();

            ////2.yöntem 
            ////var q = Ogrenciler.Where(x => x.Dogum_Tarihi.DayOfWeek == DayOfWeek.Friday);
            ////List<Ogrenci> ogrenciler1 = new List<Ogrenci>();
            ////ogrenciler1 = q.ToList();
            //ogrenciler1.ForEach(x => Console.WriteLine(x.Ad.ToString() +" " 
            //    + x.Soyad.ToString() + " " +
            //    x.Dogum_Tarihi.ToString()));
            //Console.WriteLine(ogrenciler1.GetType().ToString());


            //ogr demo sınıfından yapalım.

            List<OgrDemo> demolar = Ogrenciler.Select(x => new OgrDemo(No: x.Id, AdSoyad: x.Ad + " " + x.Soyad)).ToList();



            foreach (var item in demolar)
            {
                Console.WriteLine(item.No.ToString() + " " + item.AdSoyad.ToString());
            }



            Console.ReadLine();
        }
    }
    class OgrDemo {
        public int No{ get; set; }
        public string AdSoyad{ get; set; }

        public OgrDemo(){}
        public OgrDemo(int No, string AdSoyad)
        {
            this.No = No;
            this.AdSoyad = AdSoyad;
        }
    }
}
