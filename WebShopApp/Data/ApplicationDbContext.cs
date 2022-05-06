using Microsoft.EntityFrameworkCore;
using WebShopApp.Models.Entities;

namespace WebShopApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public virtual DbSet<ProductEntity> Products { get; set; }
        public virtual DbSet<CategoryEntity> Categories { get; set; }
        public virtual DbSet<BrandEntity> Brands { get; set; }


    }
}
