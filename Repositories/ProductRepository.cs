
using System.Collections.Generic;
using LegacyOrderSystem.Models;

namespace LegacyOrderSystem.Repositories
{
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product{ Name="Laptop", Price=1200 },
                new Product{ Name="Mouse", Price=20 }
            };
        }
    }
}
