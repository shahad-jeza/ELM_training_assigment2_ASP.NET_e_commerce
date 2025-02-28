using ECommerceApp.Models; 
using System.Collections.Generic;

namespace ECommerceApp.Data
{
    public static class ProductData
    {
        public static List<Product> Products = new List<Product>
        {
            new Product { ProductId = 1, Name = "Laptop", Price = 1200 },
            new Product { ProductId = 2, Name = "Smartphone", Price = 800 },
            new Product { ProductId = 3, Name = "Tablet", Price = 600 }
        };
    }
}