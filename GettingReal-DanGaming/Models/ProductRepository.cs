using System.IO;

namespace GettingReal_DanGaming.Models
{
    public class ProductRepository
    {
        private List<Product> products;

        public ProductRepository() 
        {
            products = new List<Product>();
            InitializeRepository();
        }

        private void InitializeRepository()
        {
            try
            {
                using (StreamReader reader = new StreamReader("products.csv"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] parts = line.Split(";");
                        Product product = new Product() 
                        {
                            Id = int.Parse(parts[0]),
                            Name = parts[1],
                            Description = string.IsNullOrEmpty(parts[2]) ? null : parts[2],
                            Brand = parts[3].ToString(),
                            Price = double.Parse(parts[4]),
                            Quantity = int.Parse(parts[5]),
                            MinimumQuantity = int.Parse(parts[6]),
                            DateOfRecipt = parts[7],
                            CategoryId = int.Parse(parts[8]),
                            SubcategoryId = string.IsNullOrEmpty(parts[9]) ? null : int.Parse(parts[9])
                        };

                        products.Add(product);
                        line = reader.ReadLine();
                    }
                }
            } 
            catch (Exception)
            {
                throw;
            }
        }

        private void SaveRepository()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("products.csv", false))
                {
                    foreach (Product product in products)
                    {
                        writer.WriteLine(product.ToString());
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product Add(string name, string brand, double price, int quantity, int categoryId, int? subcategoryId, string? description)
        {
            int id = 1;
            Product? lastProduct = products.LastOrDefault();
            if (lastProduct != null)
            {
                id = lastProduct.Id + 1;
            } 
            
            Product product = new Product()
            {
                Id = id,
                Name = name,
                Description = description,
                Brand = brand,
                Price = price,
                Quantity = quantity,
                MinimumQuantity = 3,
                DateOfRecipt = DateTime.Now.ToString("dd/MM/yyyy"),
                CategoryId = categoryId,
                SubcategoryId = subcategoryId
            };

            products.Add(product);
            SaveRepository();
            return product;
        }
    }
}
