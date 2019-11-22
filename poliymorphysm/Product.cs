using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poliymorphysm
{
    class Product
    {
        public double Price { get; set; }
        public int ProductId { get; set; }
        public double KDVRate { get; set; }
        public string ProductName { get; set; }
        public Product()
        {
            this.KDVRate = 0.18;
            this.Price = 0;

        }
        public Product(int ProductId, double Price=1.0, double KDVRate=0.18, string ProductName="Ürün")
        {
            this.Price = Price;
            this.ProductId = ProductId;
            this.ProductName = ProductName;
            this.KDVRate = KDVRate;
        }
    }

}
