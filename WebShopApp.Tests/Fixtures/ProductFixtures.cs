using System.Collections.Generic;
using WebShopApp.Models;

namespace WebShopApp.Tests.Fixtures
{
    public static class ProductFixtures
    {
        public static IEnumerable<ProductModel> GetTestProducts() => new List<ProductModel>
        {
            new ProductModel { Id = 1, Name = "Jeans", Color = "Black", PriceEUR = 20, PriceUSD = 20, Size = "M", Amount = 3, OnSale = true, ImgUrl = "bild", BrandId = 2, CategoryId = 2 },
            new ProductModel { Id = 1, Name = "Shirt", Color = "Red", PriceEUR = 20, PriceUSD = 20, Size = "M", Amount = 3, OnSale = true, ImgUrl = "bild", BrandId = 2, CategoryId = 2 },
            new ProductModel { Id = 1, Name = "Jacket", Color = "Green", PriceEUR = 20, PriceUSD = 20, Size = "M", Amount = 3, OnSale = true, ImgUrl = "bild", BrandId = 2, CategoryId = 2 },

        };
    }
}
