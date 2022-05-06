using Microsoft.EntityFrameworkCore;
using WebShopApp.Data;
using WebShopApp.Models;

namespace WebShopApp.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> GetProducts();
        Task<ProductModel> GetProductById(int id);
        Task<IEnumerable<ProductModel>> GetProductByCategory(int categoryId);
        Task<IEnumerable<ProductModel>> GetProductByColor(string color);
        Task<IEnumerable<ProductModel>> GetProductBySize(string size);
        Task<IEnumerable<ProductModel>> GetProductByBrand(int brandId);


    }
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductModel>> GetProducts()
        {
            var products = new List<ProductModel>();
            foreach (var product in await _context.Products.Include(x => x.Brand).Include(x => x.Category).ToListAsync())
            {
                products.Add(new ProductModel(
                    product.Id,
                    product.Name,
                    product.Color,
                    product.PriceEUR,
                    product.PriceUSD,
                    product.Size,
                    product.Amount,
                    product.OnSale,
                    product.ImgUrl,
                    new BrandModel(product.Brand.Name),
                    new CategoryModel(product.Category.Name)
                    ));
            }
            return products;
        }

        public async Task<ProductModel> GetProductById(int id)
        {
            var productEntity = await _context.Products.Include(x => x.Brand).Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);

            return new ProductModel(
                    productEntity.Id,
                    productEntity.Name,
                    productEntity.Color,
                    productEntity.PriceEUR,
                    productEntity.PriceUSD,
                    productEntity.Size,
                    productEntity.Amount,
                    productEntity.OnSale,
                    productEntity.ImgUrl,
                    productEntity.BrandId,
                    productEntity.CategoryId,
                    new BrandModel(productEntity.Brand.Name),
                    new CategoryModel(productEntity.Category.Name)
                );
        }

        public async Task<IEnumerable<ProductModel>> GetProductByCategory(int categoryId)
        {
            var allProducts = await GetProducts();

            var products = new List<ProductModel>();
            foreach (var product in await _context.Products.Where(product => product.CategoryId == categoryId).ToListAsync())
            {
                products.Add(new ProductModel(
                product.Id,
                product.Name,
                product.Color,
                product.PriceEUR,
                product.PriceUSD,
                product.Size,
                product.Amount,
                product.OnSale,
                product.ImgUrl,
                new BrandModel(product.Brand.Name),
                new CategoryModel(product.Category.Name)
             ));
            }
            return products;
        }

        public async Task<IEnumerable<ProductModel>> GetProductByColor(string color)
        {
            var allProducts = await GetProducts();

            var products = new List<ProductModel>();
            foreach (var product in await _context.Products.Where(product => product.Color == color).ToListAsync())
            {
                products.Add(new ProductModel(
                product.Id,
                product.Name,
                product.Color,
                product.PriceEUR,
                product.PriceUSD,
                product.Size,
                product.Amount,
                product.OnSale,
                product.ImgUrl,
                new BrandModel(product.Brand.Name),
                new CategoryModel(product.Category.Name)
             ));
            }
            return products;
        }

        public async Task<IEnumerable<ProductModel>> GetProductBySize(string size)
        {
            var allProducts = await GetProducts();

            var products = new List<ProductModel>();
            foreach (var product in await _context.Products.Where(product => product.Size == size).ToListAsync())
            {
                products.Add(new ProductModel(
                product.Id,
                product.Name,
                product.Color,
                product.PriceEUR,
                product.PriceUSD,
                product.Size,
                product.Amount,
                product.OnSale,
                product.ImgUrl,
                new BrandModel(product.Brand.Name),
                new CategoryModel(product.Category.Name)
             ));
            }
            return products;
        }

        public async Task<IEnumerable<ProductModel>> GetProductByBrand(int brandId)
        {
            var allProducts = await GetProducts();

            var products = new List<ProductModel>();
            foreach (var product in await _context.Products.Where(product => product.BrandId == brandId).ToListAsync())
            {
                products.Add(new ProductModel(
                product.Id,
                product.Name,
                product.Color,
                product.PriceEUR,
                product.PriceUSD,
                product.Size,
                product.Amount,
                product.OnSale,
                product.ImgUrl,
                new BrandModel(product.Brand.Name),
                new CategoryModel(product.Category.Name)
             ));
            }
            return products;
        }
    }
}

