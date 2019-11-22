using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace action_ve_func
{
    class Program
    {
        static void Main(string[] args)
        {
            //ACTION
            // action geriye değer dönmeyen(void) metotlar için kullanılır.
            //delegation geriye değer dönmeyen .Net versiyonudur.
            Action<int, string> action = new Action<int, string>(KullanıcıBilgi);

            action.Invoke(432, "Kemal Kara");


            //FUNC
            Func<DateTime, double> hesap = new Func<DateTime ,double>(yas_gun_hesapla);
            double a = hesap(new DateTime(1993,02,02));

            Console.WriteLine("Yaşadığınız Gün Sayısı: " + a.ToString());

            Console.ReadLine();
        }

        static void KullanıcıBilgi(int Id, string ad) {
            Console.WriteLine("Kullanıcı Id: " + Id.ToString());
            Console.WriteLine("Kullanıcı Adı: " + ad);
        }

        static double yas_gun_hesapla(DateTime birthdate)
        {
            return (DateTime.Now - birthdate).TotalDays;
        }
    }
}
