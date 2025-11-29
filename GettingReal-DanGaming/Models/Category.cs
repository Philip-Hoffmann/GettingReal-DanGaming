namespace GettingReal_DanGaming.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string ProductType { get; set; }

        public override string ToString()
        {
            return $"{Id};{ProductType}";
        }
    }
}
