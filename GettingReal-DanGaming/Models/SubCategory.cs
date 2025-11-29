namespace GettingReal_DanGaming.Models
{
    public class Subcategory
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string? Manufacturer { get; set; }

        public int CategoryId { get; set; }

        public override string ToString()
        {
            return $"{Id};{ModelName};{Manufacturer};{CategoryId}";
        }
    }
}
