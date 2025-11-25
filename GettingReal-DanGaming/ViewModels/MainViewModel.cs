using GettingReal_DanGaming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_DanGaming.ViewModels
{
    public class MainViewModel
    {
        private CategoryRepository categoryRepo;
        private ProductRepository productRepo;

        public List<ProductViewModel> ProductsVM { get; set; }

        public MainViewModel()
        {
            categoryRepo = new CategoryRepository();
            productRepo = new ProductRepository();

            ProductsVM = new List<ProductViewModel>();
            productRepo.GetAll().ForEach(product =>
            {
                ProductsVM.Add(new ProductViewModel(product));
            });
        }
    }
}
