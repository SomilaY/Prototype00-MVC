namespace Prototype00_MVC.Models
{
    public class Product
    {
        public string? code { get; set; }
        public string? Desc { get; set; }
        public double Price { get; set; }

        public Product(string? code, string? desc, double price)
        {
            this.code = code;
            Desc = desc;
            Price = price;
        }
    }
}
