using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_DanGaming.Models
{
    public class CategoryRepository
    {
        private List<Category> categories;
        private List<Subcategory> subcategories;

        public CategoryRepository()
        {
            categories = new List<Category>();
            subcategories = new List<Subcategory>();
        }

        public List<Category> GetCategories()
        {
            return categories;
        }

        public List<Subcategory> GetSubcategories()
        {
            return subcategories;
        }
    }
}
