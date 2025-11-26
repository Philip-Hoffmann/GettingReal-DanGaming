using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_DanGaming.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int MinimumQuantity { get; set; }
        public string DateOfRecipt { get; set; }

        public int CategoryId { get; set; }
        public int? SubcategoryId { get; set; }

        public int AddQuantity(Product product)
        {
            return 0;
        }

        public int RemoveQuantity(Product product)
        {
            return 0;
        }

        public void EditProduct(Product product)
        {
        }
    }
}
