using System.ComponentModel;
using System.Runtime.CompilerServices;
using GettingReal_DanGaming.Models;

namespace GettingReal_DanGaming.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        private Product product;

        public string Name 
        { 
            get { return product.Name; }
            set
            {
                product.Name = value;
                OnPropertyChanged();
            }
        }

        public string? Description
        {
            get { return product.Description; }
            set
            {
                product.Description = value;
                OnPropertyChanged();
            }
        }

        public string Brand
        {
            get { return product.Brand; }
            set
            {
                product.Brand = value;
                OnPropertyChanged();
            }
        }

        public double Price
        {
            get { return product.Price; }
            set
            {
                product.Price = value;
                OnPropertyChanged();
            }
        }

        public int Quantity
        {
            get { return product.Quantity; }
            set
            {
                product.Quantity = value;
                OnPropertyChanged();
            }
        }

        public int CategoryId
        {
            get { return product.CategoryId; }
            set
            {
                product.CategoryId = value;
                product.SubcategoryId = null;
                SubcategoryName = null;
                OnPropertyChanged();
            }
        }

        public int? SubcategoryId
        {
            get { return product.SubcategoryId; }
            set 
            { 
                product.SubcategoryId = value;
                OnPropertyChanged();
            }
        }

        private string? _categoryName;
        public string? CategoryName 
        { 
            get { return _categoryName; } 
            set
            {
                _categoryName = value;
                OnPropertyChanged();
            }
        }

        private string? _subcategoryName;
        public string? SubcategoryName
        {
            get { return _subcategoryName; }
            set
            {
                _subcategoryName = value;
                OnPropertyChanged();
            }
        }

        public ProductViewModel(Product product)
        {
            this.product = product;
        }

        public ProductViewModel(Product product, CategoryRepository categoryRepo)
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

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
