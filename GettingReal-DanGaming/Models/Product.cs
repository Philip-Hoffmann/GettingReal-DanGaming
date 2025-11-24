using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_DanGaming.Models
{
    public class Products
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public integer Quantity { get; set; }
        public integer MinimumQuantity { get; set; }
        private string _dateOfReceipt;

        public string DateOfRecipt
        {
            get { return _dateOfReceipt; }
            set { _dateOfReceipt = value; }
        }

    }
}
