using AutoMapper;
using WebShopApp.Models;
using WebShopApp.Models.Entities;

namespace WebShopApp.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CategoryEntity, CategoryModel>()
                .ForMember(d => d.ProductCount, option => option.MapFrom(s => s.Products.Count));
            CreateMap<ProductEntity, ArrivalModel>()
                .ForMember(d => d.HotSale, option => option.MapFrom(s => s.OnSale))
                .ForMember(d => d.Category, option => option.MapFrom(s => s.Category.Name))
                .ForMember(d => d.Price, option => option.MapFrom(s => s.PriceEUR));


        }
    }
}
