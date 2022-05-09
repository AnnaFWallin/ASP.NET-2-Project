using WebShopApp.Models;

namespace WebShopApp.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryModel> AddAsync(CategoryModel categoryModel, CancellationToken cancellationToken);
        Task<CategoryModel> UpdateAsync(CategoryModel categoryModel, CancellationToken cancellationToken);
        Task<CategoryModel> GetAsync(int id, CancellationToken cancellationToken);
        Task<IEnumerable<CategoryModel>> GetAsync(CancellationToken cancellationToken);
        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
    }
}
