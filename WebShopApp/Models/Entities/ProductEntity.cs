using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }

    }
}
