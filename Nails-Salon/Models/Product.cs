namespace Nails_Salon.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public ProductTypes.Type Type {get;set;}
        public string ImgUrl { get; set; }
    }
}