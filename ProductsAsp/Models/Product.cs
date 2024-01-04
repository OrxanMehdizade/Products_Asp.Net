namespace ProductsAsp.Models
{
    public class Product
    {
        static int _staticId = 0;
        public int Id { get; set; } = ++_staticId;
        public string ProductName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
    }
}
