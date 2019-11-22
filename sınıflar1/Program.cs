using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflar1
{
    class Program
    {
        static void Main(string[] args)
        {

            Araba Mercedes1 = new Araba(); // PARANTEZLER CONSTRUCTOR METHODS İLE İLGİLİDİR!
            //    //Mercedes1.renk = "Kırmızı";
            //    //Console.WriteLine("Renk: " + Mercedes1.renk);
            //    //Console.WriteLine("Seri No: " + Mercedes1.seri_no); 
            //    // burada bir seri numarası olmadığı için göstermeyecek

            //    ////Classs overload ile oluşturalım:
            //    //Araba Mercedes2 = new Araba(hız:300);
            //    //Console.WriteLine("Renk: " + Mercedes2.renk);
            //    //Console.WriteLine("Seri No: " + Mercedes2.seri_no);

            Mercedes1.SetMotorHacmi(3.0);
            Mercedes1.Uretici = "MERCEDES";
            Console.WriteLine("Üretici: " + Mercedes1.Uretici);
            Console.WriteLine("Motor Hacmi: " + Mercedes1.GetMotorHacmi());
            Console.WriteLine("Seri No: " + Mercedes1.SeriNo);

            Console.ReadLine();
        }
    }
}
