using GettingReal_DanGaming.Commands;
using GettingReal_DanGaming.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace GettingReal_DanGaming.ViewModels
{
    public class AddProductViewModel : INotifyPropertyChanged
    {
        private CategoryRepository categoryRepo;
        private ProductRepository productRepo;

        public ObservableCollection<ProductViewModel> ProductsVM { get; set; }
        public ObservableCollection<CategoryViewModel> CategoriesVM { get; set; }
        public ObservableCollection<SubcategoryViewModel> SubcategoriesVM { get; set; }

        public AddProductViewModel()
        {
            categoryRepo = new CategoryRepository();
            productRepo = new ProductRepository();

            ProductsVM = new ObservableCollection<ProductViewModel>();
            CategoriesVM = new ObservableCollection<CategoryViewModel>();
            SubcategoriesVM = new ObservableCollection<SubcategoryViewModel>();

            categoryRepo.GetCategories().ForEach(category =>
            {
                CategoriesVM.Add(new CategoryViewModel(category));
            });
        }

        public bool IsAvailable 
        { 
            get { return SelectedProduct != null; } 
        }

        private ProductViewModel? _selectedProduct;
        public ProductViewModel? SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                if (_selectedProduct != value)
                {
                    _selectedProduct = value;
                    UpdateSubcategories();
                    OnPropertyChanged();
                    OnPropertyChanged("IsAvailable");
                }
            }
        }

        public void UpdateCategoryName()
        {
            if (SelectedProduct == null)
            {
                return;
            }

            Category? category = categoryRepo.GetCategory(SelectedProduct.CategoryId);
            if (category != null)
            {
                SelectedProduct.CategoryName = category.ProductType;
            }
        }

        public void UpdateSubcategoryName()
        {
            if (SelectedProduct == null)
            {
                return;
            }

            Subcategory? subcategory = categoryRepo.GetSubcategory(SelectedProduct.SubcategoryId);
            if (subcategory != null)
            {
                SelectedProduct.SubcategoryName = $"{subcategory.ModelName}, {subcategory.Manufacturer}";
            }
        }

        public void UpdateSubcategories()
        {
            if (SelectedProduct == null)
            {
                return;
            }

            SubcategoriesVM.Clear();
            categoryRepo.GetSubcategoriesOfCategory(SelectedProduct.CategoryId).ForEach(subcategory =>
            {
                SubcategoriesVM.Add(new SubcategoryViewModel(subcategory));
            });
        }

        public ICommand AddProductCmd { get; set; } = new AddProductCommand();
        public ICommand RemoveProductCmd { get; set; } = new RemoveProductCommand();
        public ICommand AddAllProductsCmd { get; set; } = new AddAllProductsCommand();

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
