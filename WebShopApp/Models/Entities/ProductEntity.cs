using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopApp.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal PriceEUR { get; set; }
        public decimal PriceUSD { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public bool OnSale { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        [Required]
        public BrandEntity Brand { get; set; }
        [Required]
        public CategoryEntity Category { get; set; }

    }
}
