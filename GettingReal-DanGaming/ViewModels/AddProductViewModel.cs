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
                    OnPropertyChanged();
                    OnPropertyChanged("IsAvailable");
                }
            }
        }

        public ICommand AddProductCmd { get; set; } = new AddProductCommand();

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
