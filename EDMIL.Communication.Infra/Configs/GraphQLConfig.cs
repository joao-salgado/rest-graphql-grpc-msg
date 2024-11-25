using EDMIL.Communication.Application.UseCases.Product.Create;
using EDMIL.Communication.Infra.Controllers.GraphQL;

//using EDMIL.Communication.Infra.Controllers.GraphQL;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EDMIL.Communication.Infra.Configs
{
    public static class GraphQLConfig
    {
        public static IServiceCollection AddGraphQLQueries(
            this IServiceCollection services
        )
        {
            services
                .AddGraphQLServer()
                .AddQueryType<ProductQuery>()      // Register your Query type
                .AddMutationType<ProductMutation>() // Register your Mutation type
                .AddFiltering()             // Enable filtering
                .AddSorting();              // Enable sorting

            return services;
        }

    }
}
