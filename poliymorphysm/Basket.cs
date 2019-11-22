using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poliymorphysm
{
    class Basket
    {
        List<Product> products = new List<Product>();

        public void Add(Product ürün)
        {
            products.Add(ürün);
        }
        public void ToplamFiyat()
        {
            double toplam = 0; 
            foreach (Product ürün in products)
            {
                toplam += ürün.Price;
            }

            Console.WriteLine("Toplam Fiyat: " + toplam);
        }
    }
}
