using System.Collections.ObjectModel;
using System.Windows.Input;
using GettingReal_DanGaming.Commands;
using GettingReal_DanGaming.Models;

namespace GettingReal_DanGaming.ViewModels
{
    public class MainViewModel
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

        public ICommand ShowLoginDialogCmd { get; set; } = new ShowLoginDialogCommand();
        public ICommand ShowAddProductCmd { get; set; } = new ShowAddProductCommand();

        private string _productSearch;
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
                    if (product.Name.Contains(_productSearch, StringComparison.OrdinalIgnoreCase))
                    {
                        ProductsVM.Add(new ProductViewModel(product, categoryRepo));
                    }
                });
            }
        }

        public void AddProduct(ProductViewModel productVM)
        {
            Product product = productRepo.Add(productVM.Name, productVM.Brand, productVM.Price, productVM.Quantity, productVM.CategoryId, productVM.SubcategoryId, productVM.Description);
            ProductsVM.Add(new ProductViewModel(product, categoryRepo));
        }
    }
}
