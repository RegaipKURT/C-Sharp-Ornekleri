using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poliymorphysm
{
    internal class Bread : Product 
    {
        private Tür tür;
        private Gramaj gramaj;

        public Bread()
        {
            ProductName = "Ekmek";
        }

        public Tür Tür { get => tür; set => tür = value; }
        public Gramaj Gramaj { get => gramaj; set => gramaj = value; }
    }

    public enum Tür
    {   
        Normal = 1,
        Kepekli =2,
        Buğday = 3,
        Odun = 4
    }

    public enum Gramaj
    {
        Yuz= 100,
        YuzElli = 150,
        Ikıyuz = 200,
        UcYuz = 300
    }
}
