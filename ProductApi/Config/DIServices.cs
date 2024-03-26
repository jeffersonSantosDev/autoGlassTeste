using DomainProduct.Interfaces.IServices;
using DomainProduct.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ProductApi.Config
{
    public class DIServices
    {
        public void MapDependencies(IServiceCollection services)
        {
            // Mapeia as dependências relacionadas a NewOrder
            services.AddTransient<IProductService, ProductService>();
        }
    }
}
