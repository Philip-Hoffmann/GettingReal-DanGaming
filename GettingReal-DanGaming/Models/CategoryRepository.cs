namespace GettingReal_DanGaming.Models
{
    public class CategoryRepository
    {
        private List<Category> categories;
        private List<Subcategory> subcategories;

        public CategoryRepository()
        {
            categories = new List<Category>()
            {
                new Category { Id = 1, ProductType = "Laptops" },
                new Category { Id = 2, ProductType = "Grafikkort" },
            };

            subcategories = new List<Subcategory>()
            {
                new Subcategory { Id = 1, ModelName = "RTX 5060", Manufacturer = "Nvidia", CategoryId = 2 }
            };
        }

        public List<Category> GetCategories()
        {
            return categories;
        }

        public List<Subcategory> GetSubcategories()
        {
            return subcategories;
        }

        public List<Subcategory> GetSubcategoriesOfCategory(int categoryId)
        {
            List<Subcategory> subcategories = new List<Subcategory>();
            foreach (Subcategory subcategory in this.subcategories)
            {
                if (subcategory.CategoryId == categoryId)
                {
                    subcategories.Add(subcategory);
                }
            }

            return subcategories;
        }

        public Category? GetCategory(int id)
        {
            Category? result = null;
            foreach (Category category in categories)
            {
                if (category.Id == id)
                {
                    result = category;
                    break;
                }
            }

            return result;
        }

        public Subcategory? GetSubcategory(int? id)
        {
            if (id == null)
            {
                return null;
            }

            Subcategory? result = null;
            foreach (Subcategory subcategory in subcategories)
            {
                if (subcategory.Id == id)
                {
                    result = subcategory;
                    break;
                }
            }

            return result;
        }
    }
}
