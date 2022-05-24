using WebShopApp.Models;

namespace WebShopApp.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> GetProducts();
        Task<ProductModel> GetProductById(int id);
        Task<IEnumerable<ProductModel>> GetProductByCategory(int categoryId);
        Task<IEnumerable<ProductModel>> GetProductByColor(string color);
        Task<IEnumerable<ProductModel>> GetProductBySize(string size);
        Task<IEnumerable<ProductModel>> GetProductByBrand(int brandId);
        Task<IEnumerable<ProductModel>> GetProductsOnSale();
        Task<IEnumerable<ProductModel>> GetProductsInStock();
        Task<IEnumerable<ProductModel>> GetProductsByPrice(int min, int max);

    }
}

