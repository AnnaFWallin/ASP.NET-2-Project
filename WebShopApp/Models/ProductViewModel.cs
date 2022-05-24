namespace WebShopApp.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
        public IEnumerable<ProductModel> Products { get; set; }

    }
}
