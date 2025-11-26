using GettingReal_DanGaming.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_DanGaming.ViewModels
{
    public class AddProductViewModel
    {
        private CategoryRepository categoryRepo;
        private ProductRepository productRepo;

        public AddProductViewModel()
        {
            categoryRepo = new CategoryRepository();
            productRepo = new ProductRepository();
        }
    }
}
