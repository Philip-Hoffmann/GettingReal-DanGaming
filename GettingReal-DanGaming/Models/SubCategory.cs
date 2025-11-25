using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_DanGaming.Models
{
    internal class Subcategory
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Manufacturer { get; set; }

        public int CategoryId { get; set; }

        public void Remove()
        {
            // Mangler metoden. :)
        }

        public void AddProduct(Product product)
        {
            // Mangler metoden. :) 
        }
    }
}
