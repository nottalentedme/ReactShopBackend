using System.Xml.Linq;

namespace ShopBackend.Helpers
{
    public static class FakeDatabase
    {
        public static List<Product> _products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Image = "kepka.jpg",
                Title = "Кепка BunkerDev 2",
                Description = "Кепка BunkerDev 2",
                Price = 900,
                Quantity = 5
            },
            new Product()
            {
                Id = 2,
                Image = "hoodie.jpg",
                Title = "Худи Limited",
                Description = "Худи Limited",
                Price = 1700,
                Quantity = 0
            },
            new Product()
            {
                Id = 3,
                Image = "kros.jpg",
                Title = "Кроссовки Limited",
                Description = "Кроссовки Limited",
                Price = 10000,
                Quantity = 4
            },
            new Product()
            {
                Id = 4,
                Image = "pants.jpg",
                Title = "Штаны Limited",
                Description = "Штаны Limited",
                Price = 5000,
                Quantity = 3
            }
        };
    }

    public class Product
    {
        public int Id { get; set; }
        public string Image { get; set; } = "";
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public int Price { get; set; }
        public int Quantity { get; set; }

    }
}
