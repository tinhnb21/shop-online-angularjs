using AutoMapper;
using OnlineShop.Model.Models;
using OnlineShop.Web.Models;

namespace OnlineShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            //post
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();

            //product
            Mapper.CreateMap<Product, ProductViewModel>();
            Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();
            Mapper.CreateMap<ProductTag, ProductTagViewModel>();
        }
    }
}