using System.Collections.Generic;
using System.Threading.Tasks;
using WebShopApp.Models;

namespace WebShopApp.Tests.Repository
{
    public static class ProductModelFixtures
    {
        
        private static List<ProductModel> _products = new List<ProductModel>
        {
            new ProductModel { Id = 1, Name = "Test product 1", Color = "Black", PriceEUR = 10, PriceUSD = 10, Size = "M", Amount = 1, OnSale = true, ImgUrl = "bild", BrandId = 2, CategoryId = 2 },
            new ProductModel { Id = 2, Name = "Test product 2", Color = "Red", PriceEUR = 20, PriceUSD = 20, Size = "M", Amount = 1, OnSale = true, ImgUrl = "bild", BrandId = 2, CategoryId = 2 },
            new ProductModel { Id = 3, Name = "Test product 3", Color = "Green", PriceEUR = 30, PriceUSD = 30, Size = "M", Amount = 3, OnSale = true, ImgUrl = "bild", BrandId = 2, CategoryId = 2 },

        };

        public static async Task<List<ProductModel>> GetAsync()
        {
            await Task.Delay(300);
            return _products;
        }
    }
}