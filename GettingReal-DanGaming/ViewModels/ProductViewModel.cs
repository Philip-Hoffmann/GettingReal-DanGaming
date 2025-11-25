using GettingReal_DanGaming.Models;

namespace GettingReal_DanGaming.ViewModels
{
    public class ProductViewModel
    {
        private Product product;

        public string Name 
        { 
            get { return product.Name; }
            set { product.Name = value; } 
        }

        public string Brand
        {
            get { return product.Brand; }
            set { product.Brand = value; }
        }

        public double Price
        {
            get { return product.Price; }
            set { product.Price = value; }
        }

        public int Quantity
        {
            get { return product.Quantity; }
            set { product.Quantity = value; }
        }

        public ProductViewModel(Product product)
        {
            this.product = product;
        }   
    }
}
