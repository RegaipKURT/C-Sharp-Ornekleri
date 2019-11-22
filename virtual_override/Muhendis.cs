using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soyut_nesneler
{
    class Muhendis : calisan
    {
        public string  Departman{ get; set; }
        public int Kıdem{ get; set; }
        public new int MaasHesapla()
        {
            return 5500;
        }
        public override int MaasHesapla_base()
        {
            return base.MaasHesapla_base() * 4 ; // base temel sınıfın olduğunu gösterir.
        }
    }
}
