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
            products = new List<Product>();
        }

        public List<Product> GetAll()
        {
            return products;
        }
    }
}
