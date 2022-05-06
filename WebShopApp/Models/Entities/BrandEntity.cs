using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Models.Entities
{
    public class BrandEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 
        public ICollection<ProductEntity> Products { get; set; }
    }
}
