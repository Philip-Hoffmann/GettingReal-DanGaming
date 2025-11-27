using GettingReal_DanGaming.Models;

namespace GettingReal_DanGaming.ViewModels
{
    public class CategoryViewModel
    {
        private Category category;

        public int Id
        {
            get { return category.Id; }
        }

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
