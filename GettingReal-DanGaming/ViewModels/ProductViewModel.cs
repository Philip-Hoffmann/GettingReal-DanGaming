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

        public string? CategoryName { get; set; }
        public string? SubcategoryName { get; set; }

        public ProductViewModel(Product product)
        {
            this.product = product;
        }

        public ProductViewModel(Product product, CategoryRepository? categoryRepo)
        {
            this.product = product;

            Category? category = categoryRepo.GetCategory(product.CategoryId);
            if (category != null)
            {
                CategoryName = category.ProductType;
            }

            Subcategory? subcategory = categoryRepo.GetSubcategory(product.SubcategoryId);
            if (subcategory != null)
            {
                SubcategoryName = $"{subcategory.ModelName}, {subcategory.Manufacturer}";
            }
        }   
    }
}
