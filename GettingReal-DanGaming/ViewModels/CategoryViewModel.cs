using GettingReal_DanGaming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_DanGaming.ViewModels
{
    public class CategoryViewModel
    {
        private Category category;

        public string ProductType
        {
            get { return category.ProductType; }
        }

        public CategoryViewModel(Category category)
        {
            this.category = category;
        }
    }
}
