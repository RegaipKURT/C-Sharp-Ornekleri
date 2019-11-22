using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_miras
{
    class ucgen : ikiboyut
    {
        public ucgen()
        {
            Console.WriteLine("Üçgen oluşturuldu.");
        }

        public string Stil { get; set; }

        public double AlanHesapla()
        {
            return genislik * yukseklik / 2;
        }
    }
}
