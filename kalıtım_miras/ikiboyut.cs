using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_miras
{
    class ikiboyut
    {

        public ikiboyut()
        {
            Console.WriteLine("İki boyutlu nesne oluşturuldu.");
        }

        public double genislik { get; set; }
        public double yukseklik { get; set; }

        public void Goster()
        {
            Console.WriteLine("Genişlik: " + genislik);
            Console.WriteLine("Yükseklik: " + yukseklik);
        }
        public void AlanGoster()
        {
            Console.WriteLine("Alan = " + genislik * yukseklik);
        }
    }
}
