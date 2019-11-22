using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soyut_nesneler
{
    class Muhendis : Calisan
    {
        public string Departman { get; set; }
        public int Kıdem { get; set; }
        
        public override int MaasHesapla()
        {
            return 5500; 
        }
    }
}
