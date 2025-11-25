using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_DanGaming.Models
{
    public class ProductRepository
    {
        private List<Product> products;

        public ProductRepository() 
        {
            products = new List<Product>() 
            {
                new Product { Id = 1, Brand = "Dell", Name = "Dell XPS 13", Price = 999.99, CategoryId = 1 },
                new Product { Id = 2, Brand = "Apple", Name = "Apple MacBook Air", Price = 1199.99, CategoryId = 1 },
                new Product { Id = 3, Brand = "HP", Name = "HP Spectre x360", Price = 1099.99, CategoryId = 1 },

                new Product { Id = 3, Brand = "MSI", Name = "Geforce RTX 5060", Price = 500.0, CategoryId = 2, SubcategoryId = 1 },
                new Product { Id = 3, Brand = "ASUS", Name = "Geforce RTX 5060", Price = 500.0, CategoryId = 2, SubcategoryId = 1 },
                new Product { Id = 3, Brand = "Gigabyte", Name = "Geforce RTX 5060", Price = 500.0, CategoryId = 2, SubcategoryId = 1 },
            };
        }

        public List<Product> GetAll()
        {
            return products;
        }
    }
}
