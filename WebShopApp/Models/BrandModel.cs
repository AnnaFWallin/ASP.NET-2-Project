namespace WebShopApp.Models
{
    public class BrandModel
    {
        public BrandModel()
        {


        }

        public BrandModel(int id)
        {
            Id = id;
        }

        public BrandModel(string name)
        {
            Name = name;
        }

        public BrandModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}