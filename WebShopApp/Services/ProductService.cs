using Microsoft.EntityFrameworkCore;
using WebShopApp.Data;
using WebShopApp.Models;

namespace WebShopApp.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> GetProducts();
        Task<ProductModel> GetProductById(int id);

    }
    public class ProductService : IProductService
    {
        private readonly ProductsDbContext _context;

        public ProductService(ProductsDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<ProductModel>> GetProducts()
        {
            var products = new List<ProductModel>();
            foreach (var product in await _context.Products.ToListAsync())
            {
                products.Add(new ProductModel(
                    product.Id,
                    product.Name,
                    product.Color,
                    product.Category));
            }
            return products;
        }

        public async Task<ProductModel> GetProductById(int id)
        {
            var productEntity = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

            return new ProductModel(
                productEntity.Id,
                productEntity.Name,
                productEntity.Color,
                productEntity.Category
                );

        }

    }
}
