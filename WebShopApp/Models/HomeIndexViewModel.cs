namespace WebShopApp.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<CategoryModel> Categories { get; set; }
        public IEnumerable<ArrivalModel> Arrivals { get; set; }

        public ShoppingCartModel ShoppingCart { get; set; } = null!;
    }
}
