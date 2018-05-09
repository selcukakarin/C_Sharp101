using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public Product()
        {

        }
        public Product(
            int productId,
            string productCode,
            string productName,
            double price)
        {
            this.ProductId = productId;
            this.ProductCode = productCode;
            this.ProductName = productName;
            this.Price = price;
        }
        public double SetKDV()
        {
            return this.Price * 1.18;
        }
    }
}
