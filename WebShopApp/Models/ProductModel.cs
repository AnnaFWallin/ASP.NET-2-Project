namespace WebShopApp.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
        }

        public ProductModel(int id, string name, string color, decimal priceEUR, decimal priceUSD, string size, int amount, bool onSale, string imgUrl)
        {
            Id = id;
            Name = name;
            Color = color;
            PriceEUR = priceEUR;
            PriceUSD = priceUSD;
            Size = size;
            Amount = amount;
            OnSale = onSale;
            ImgUrl = imgUrl;
        }

        public ProductModel(int id, string name, string color, decimal priceEUR, decimal priceUSD, string size, int amount, bool onSale, string imgUrl, BrandModel brand, CategoryModel category)
        {
            Id = id;
            Name = name;
            Color = color;
            PriceEUR = priceEUR;
            PriceUSD = priceUSD;
            Size = size;
            Amount = amount;
            OnSale = onSale;
            ImgUrl = imgUrl;
            Brand = brand;
            Category = category;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal PriceEUR { get; set; }
        public decimal PriceUSD { get; set; }
        public string Size { get; set; }
        public int Amount { get; set; }
        public bool OnSale { get; set; }
        public string ImgUrl { get; set; }
        public BrandModel Brand { get; set; }
        public CategoryModel Category { get; set; }


    }
}
