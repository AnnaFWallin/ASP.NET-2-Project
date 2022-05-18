namespace WebShopApp.Models
{
    public class ShoppingCartModel
    {
        public ShoppingCartModel()
        {
            ShoppingCart = new List<CartItemModel>();
        }

        public string? UserId { get; set; }
        public List<CartItemModel> ShoppingCart { get; set; }
        public int TotalQuantity {

            get 
            {
                int _totalQuantity = 0;
                if (ShoppingCart.Count > 0)
                    foreach (var item in ShoppingCart)
                        _totalQuantity += item.Quantity;
                return _totalQuantity; 
            } 
        }
        public decimal TotalPrice
        {

            get
            {
                decimal _totalPrice = 0;
                if (ShoppingCart.Count > 0)
                    foreach (var item in ShoppingCart)
                        _totalPrice += item.Product.PriceUSD * item.Quantity;
                return _totalPrice;
            }
        }

    }
}
