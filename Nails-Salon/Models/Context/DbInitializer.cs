using System.Linq;

namespace Nails_Salon.Models.Context
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Значки",
                        Price = 50m,
                        Size = "50x50 мм",
                        Type = ProductTypes.Type.Other,
                        ImgUrl = "/images/pin.png"
                    },
                    new Product
                    {
                        Name = "Значки",
                        Price = 50m,
                        Size = "50x50 мм",
                        Type = ProductTypes.Type.Other,
                        ImgUrl = "/images/pin.png"
                    },
                    new Product
                    {
                        Name = "Значки",
                        Price = 50m,
                        Size = "50x50 мм",
                        Type = ProductTypes.Type.Other,
                        ImgUrl = "/images/pin.png"
                    },
                    new Product
                    {
                        Name = "Значки",
                        Price = 50m,
                        Size = "50x50 мм",
                        Type = ProductTypes.Type.Other,
                        ImgUrl = "/images/pin.png"
                    },
                    new Product
                    {
                        Name = "Значки",
                        Price = 50m,
                        Size = "50x50 мм",
                        Type = ProductTypes.Type.Other,
                        ImgUrl = "/images/pin.png"
                    },
                    new Product
                    {
                        Name = "Значки",
                        Price = 50m,
                        Size = "50x50 мм",
                        Type = ProductTypes.Type.Other,
                        ImgUrl = "/images/pin.png"
                    },
                    new Product
                    {
                        Name = "Лаки",
                        Price = 1250.50m,
                        Size = "",
                        Type = ProductTypes.Type.Polish,
                        ImgUrl = "/images/6.jpg"
                    },
                    new Product
                    {
                        Name = "Лаки",
                        Price = 1250.50m,
                        Size = "",
                        Type = ProductTypes.Type.Polish,
                        ImgUrl = "/images/6.jpg"
                    },
                    new Product
                    {
                        Name = "Лаки",
                        Price = 1250.50m,
                        Size = "",
                        Type = ProductTypes.Type.Polish,
                        ImgUrl = "/images/6.jpg"
                    },
                    new Product
                    {
                        Name = "Лаки",
                        Price = 1250.50m,
                        Size = "",
                        Type = ProductTypes.Type.Polish,
                        ImgUrl = "/images/6.jpg"
                    },
                    new Product
                    {
                        Name = "Лаки",
                        Price = 1250.50m,
                        Size = "",
                        Type = ProductTypes.Type.Polish,
                        ImgUrl = "/images/6.jpg"
                    },
                    new Product
                    {
                        Name = "Лаки",
                        Price = 1250.50m,
                        Size = "",
                        Type = ProductTypes.Type.Polish,
                        ImgUrl = "/images/6.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}