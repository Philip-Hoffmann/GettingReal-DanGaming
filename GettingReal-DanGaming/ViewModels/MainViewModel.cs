using System.Collections.ObjectModel;
using System.ComponentModel;
using GettingReal_DanGaming.Models;

namespace GettingReal_DanGaming.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private CategoryRepository categoryRepo;
        private ProductRepository productRepo;

        public ObservableCollection<ProductViewModel> ProductsVM { get; set; }

        public MainViewModel()
        {
            categoryRepo = new CategoryRepository();
            productRepo = new ProductRepository();

            ProductsVM = new ObservableCollection<ProductViewModel>();
            productRepo.GetAll().ForEach(product =>
            {
                ProductsVM.Add(new ProductViewModel(product, categoryRepo));
            });
        }

        private string _productSearch;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string ProductSearch 
        { 
            get 
            {
                return _productSearch;
            }
            
            set
            {
                _productSearch = value;
                ProductsVM.Clear();
                productRepo.GetAll().ForEach(product =>
                {
                    if (product.Name.StartsWith(_productSearch, StringComparison.OrdinalIgnoreCase))
                    {
                        ProductsVM.Add(new ProductViewModel(product, categoryRepo));
                    }
                });
            }
        }
    }
}
