using DomainProduct.Interfaces.IRepositorys;
using Infrastructure.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ProductApi.Config
{
    public class DIRepository
    {
        public void RegisterDependencies(IServiceCollection services)
        {
            // Registra as dependências
            services.AddSingleton<IProductRepository, ProductRepository>();
        }
    }
}
