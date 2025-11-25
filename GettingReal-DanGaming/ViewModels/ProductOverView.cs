using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_DanGaming.ViewModels
{
    // Define ProductNameList class since it does not exist in the current context
    public class ProductNameList
    {
        public string Name { get; set; }
    }

    public class ProductOverView
    {
        public string ProductName { get; set; } = "";
        public string ProductBrand { get; set; }
        public double ProductPrice { get; set; }
        public string ProductCategory { get; set; }
        public string ProductSubCategory { get; set; }
        public int ProductQuantity { get; set; }

    }
}
