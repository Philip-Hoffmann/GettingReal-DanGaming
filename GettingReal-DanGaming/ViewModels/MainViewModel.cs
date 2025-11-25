using System.Collections.ObjectModel;
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
    }
}
