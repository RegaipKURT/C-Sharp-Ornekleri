using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_keywordu
{
    class sifreleme
    {
        static sifreleme()
        {
            
        }
        public static void sifrele(string metin)
        {
            Console.WriteLine("Şifrelenmiş Metin: " + metin.GetHashCode());
        }
        public static void coz(string metin)
        {
            Console.WriteLine("Çözülmüş Metin: " + metin);

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}   
