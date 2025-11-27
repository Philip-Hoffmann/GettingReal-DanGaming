namespace GettingReal_DanGaming.Models
{
    public class ProductRepository
    {
        private List<Product> products;

        public ProductRepository() 
        {
            products = new List<Product>() 
            {
                new Product { Id = 1, Brand = "Dell", Name = "Dell XPS 13", Price = 999.99, CategoryId = 1 },
                new Product { Id = 2, Brand = "Apple", Name = "Apple MacBook Air", Price = 1199.99, CategoryId = 1 },
                new Product { Id = 3, Brand = "HP", Name = "HP Spectre x360", Price = 1099.99, CategoryId = 1 },

                new Product { Id = 3, Brand = "MSI", Name = "Geforce RTX 5060", Price = 500.0, CategoryId = 2, SubcategoryId = 1 },
                new Product { Id = 3, Brand = "ASUS", Name = "Geforce RTX 5060", Price = 500.0, CategoryId = 2, SubcategoryId = 1 },
                new Product { Id = 3, Brand = "Gigabyte", Name = "Geforce RTX 5060", Price = 500.0, CategoryId = 2, SubcategoryId = 1 },
            };
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product Add(string name, string brand, double price, int quantity, int categoryId, int? subcategoryId, string? description)
        {
            int id = products.Last().Id++;
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
            return product;
        }
    }
}
