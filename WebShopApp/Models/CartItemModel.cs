namespace WebShopApp.Models
{
    public class CartItemModel
    {        
        public ProductModel Product { get; set; } = null!;
        public int Quantity { get; set; } = 1;
        
    }
}