using System.IO;

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

            InitializeRepository();
        }

        private void InitializeRepository()
        {
            try
            {
                using (StreamReader reader = new StreamReader("categories.csv"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] parts = line.Split(";");
                        Category category = new Category()
                        {
                            Id = int.Parse(parts[0]),
                            ProductType = parts[1]
                        };

                        categories.Add(category);
                        line = reader.ReadLine();
                    }
                }

                using (StreamReader reader = new StreamReader("subcategories.csv"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] parts = line.Split(";");
                        Subcategory subcategory = new Subcategory()
                        {
                            Id = int.Parse(parts[0]),
                            ModelName = parts[1],
                            Manufacturer = string.IsNullOrEmpty(parts[2]) ? null : parts[2],
                            CategoryId = int.Parse(parts[3])
                        };

                        subcategories.Add(subcategory);
                        line = reader.ReadLine();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SaveCategories()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("categories.csv", false))
                {
                    foreach (Category category in categories)
                    {
                        writer.WriteLine(category.ToString());
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SaveSubcategories()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("subcategories.csv", false))
                {
                    foreach (Subcategory subcategory in subcategories)
                    {
                        writer.WriteLine(subcategory.ToString());
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
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
