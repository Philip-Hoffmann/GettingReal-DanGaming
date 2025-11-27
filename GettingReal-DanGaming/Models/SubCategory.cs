namespace GettingReal_DanGaming.Models
{
    public class Subcategory
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string? Manufacturer { get; set; }

        public int CategoryId { get; set; }

        public void Remove()
        {
            // Mangler metoden. :)
        }

        public void AddProduct(Product product)
        {
            // Mangler metoden. :) 
        }
    }
}
