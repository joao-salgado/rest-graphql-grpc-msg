using EDMIL.Communication.Application.UseCases.Product.Create;
using EDMIL.Communication.Domain.Entity.Product;
using EDMIL.Communication.Infra.Repositories;

namespace EDMIL.Communication.Infra.Configs
{
    public static class UseCaseConfig
    {
        public static IServiceCollection AddUseCases(
            this IServiceCollection services
        )
        {
            services.AddScoped<ICreateProduct, CreateProduct>();

            services.AddRepositories();
            return services;
        }

        private static IServiceCollection AddRepositories(
            this IServiceCollection services
        )
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
