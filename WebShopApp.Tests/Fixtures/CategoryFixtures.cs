using System.Collections.Generic;
using WebShopApp.Models;
using WebShopApp.Models.Entities;

namespace WebShopApp.Tests.Fixtures
{
    public static class CategoryFixtures
    {
        public static IEnumerable<CategoryModel> GetTestCategories() => new List<CategoryModel>
        {
            new CategoryModel { Id = 1, Name = "Men's", ProductCount = 1, ImagePreview = "images/mens-clothing.jpg" },
            new CategoryModel { Id = 2, Name = "Women's", ProductCount = 2, ImagePreview = "images/womens-clothing.jpg" },
            new CategoryModel { Id = 3, Name = "Kids", ProductCount = 3, ImagePreview = "images/kids-clothing.jpg" },
            new CategoryModel { Id = 4, Name = "Hats", ProductCount = 2, ImagePreview = "images/hats.jpg" },
            new CategoryModel { Id = 5, Name = "Sunglasses", ProductCount = 4, ImagePreview = "images/sunglasses.jpg" },
            new CategoryModel { Id = 6, Name = "Shoes", ProductCount = 5, ImagePreview = "images/shoes.jpg" },
            new CategoryModel { Id = 7, Name = "Watches", ProductCount = 2, ImagePreview = "images/watches.jpg" }

        };

        public static IEnumerable<CategoryEntity> GetTestCategoriesEntity() => new List<CategoryEntity>
        {
            new CategoryEntity { Id = 1, Name = "Men's", ImagePreview = "images/mens-clothing.jpg" },
            new CategoryEntity { Id = 2, Name = "Women's", ImagePreview = "images/womens-clothing.jpg" },
            new CategoryEntity { Id = 3, Name = "Kids", ImagePreview = "images/kids-clothing.jpg" },
            new CategoryEntity { Id = 4, Name = "Hats", ImagePreview = "images/hats.jpg" },
            new CategoryEntity { Id = 5, Name = "Sunglasses", ImagePreview = "images/sunglasses.jpg" },
            new CategoryEntity { Id = 6, Name = "Shoes", ImagePreview = "images/shoes.jpg" },
            new CategoryEntity { Id = 7, Name = "Watches", ImagePreview = "images/watches.jpg" }

        };
    }
}
