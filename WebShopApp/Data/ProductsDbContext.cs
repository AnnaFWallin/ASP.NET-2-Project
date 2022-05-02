using Microsoft.EntityFrameworkCore;
using WebShopApp.Models.Entities;

namespace WebShopApp.Data
{
    public class ProductsDbContext : DbContext
    {
        protected ProductsDbContext()
        {
        }

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {
        }

        public virtual DbSet<ProductEntity> Products { get; set; }

    }
}
