namespace WebShopApp.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
        }

        public ProductModel(int id, string name, string category, string color)
        {
            Id = id;
            Name = name;
            Category = category;
            Color = color;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }

    }
}
