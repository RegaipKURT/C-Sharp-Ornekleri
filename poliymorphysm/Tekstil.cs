using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poliymorphysm
{
    class Tekstil : Product
    {
        public Tekstil()
        {
            ProductName = "Elbise";
        }
        private Beden beden;

        public Beden Beden { get => beden; set => beden = value; }
    }
    public enum Beden
    {
        S = 1,
        M = 2,
        L = 3,
        XL = 4
    }
    public enum Marka
    {
        Kiğılı = 1,
        LCW = 2,
        POLO = 3,
        DAMAT = 4,
        ALTINYILDIZ = 5,
        KOTON =6
    }

}
