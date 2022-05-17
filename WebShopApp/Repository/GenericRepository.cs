using Microsoft.EntityFrameworkCore;
using WebShopApp.Data;

namespace WebShopApp.Repository
{
    public abstract class GenericRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;

        protected GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        protected virtual async Task<TEntity> ReadAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id) ?? null!;
        }

        protected virtual async Task<List<TEntity>> ReadAsync()
        {
            return await _context.Set<TEntity>().ToListAsync() ?? null!;
        }
    }
    
}
