using AutoMapper;
using WebShopApp.Models;
using WebShopApp.Models.Entities;

namespace WebShopApp.Repository
{

    public interface IProductRepository
    {
        public Task<ProductModel> GetAsync(int id);
        public Task<List<ProductModel>> GetAsync();
    }
    public class ProductRepository : GenericRepository<ProductEntity>, IProductRepository
    {
        private readonly IMapper _mapper;
        public ProductRepository(Data.ApplicationDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public async Task<ProductModel> GetAsync(int id)
        {
            return _mapper.Map<ProductModel>(await ReadAsync(id));
        }

        public async Task<List<ProductModel>> GetAsync()
        {
            return _mapper.Map<List<ProductModel>>(await ReadAsync());
        }
    }
}
