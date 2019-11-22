using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soyut_nesneler
{
    abstract class Calisan
    {

        // bir nesnede veya bir metotda virtual yazıyorsa bu override edilebilir demektir.

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Id { get; set; }
        public string Unvan { get; set; }

        public abstract int MaasHesapla();
        
        override public string ToString()
        {
            return Unvan + " " + Ad + " " + Soyad;
        }
    }
}
