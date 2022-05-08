namespace WebShopApp.Models
{
    public class ArrivalViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public decimal DiscountPrice { get; set; }
        public bool HotSale { get; set; }

    }
}
