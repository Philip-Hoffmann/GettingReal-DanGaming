using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_DanGaming.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int MinimumQuantity { get; set; }
        private string _dateOfReceipt;

        public string DateOfRecipt
        {
            get { return _dateOfReceipt; }
            set { _dateOfReceipt = value; }
        }

        public int addQuantity(Product product)
        {
            return 0;
        }

        public int removeQuantity(Product product)
        {
            return 0;
        }

        public void editProduct(Product product)
        {

        }

    }
}
