using EDMIL.Communication.Domain.Entity.Product;
using EDMIL.Communication.Infra.Repositories;

namespace EDMIL.Communication.Infra.Controllers.GraphQL
{
    public class ProductQuery
    {
        [UseFiltering]
        [UseSorting]
        public IQueryable<Product> List([Service] CommunicationDBContext dbContext)
        {
            return dbContext.Products;
        }
    }
}
