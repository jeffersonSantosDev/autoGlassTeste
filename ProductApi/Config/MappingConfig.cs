using AutoMapper;
using DomainProduct.Views.ProductViews;
using EntitieProduct;

namespace ProductApi.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductAddView, Product>();
                config.CreateMap<Product, ProductAddView>();
                config.CreateMap<ProductView, Product>();
                config.CreateMap<Product, ProductView>();
                config.CreateMap<ProductAddView, ProductView>();
                config.CreateMap<ProductView, ProductAddView>();
                config.CreateMap<Product, ProductUpdateView>();
                config.CreateMap<ProductUpdateView, Product>();

            });
            return mappingConfig;
        }
    }
}
