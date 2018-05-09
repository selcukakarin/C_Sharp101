﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Basket
    {
        private List<Product> products = new List<Product>();

        public void Add(Product newProduct)
        {
            if (newProduct != null)
            {
                products.Add(newProduct);
            }
        }
        public double TotalPrice()
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
        public double TotalPriceWithKDV()
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.SetKDV();
            }
            return totalPrice;
        }
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
