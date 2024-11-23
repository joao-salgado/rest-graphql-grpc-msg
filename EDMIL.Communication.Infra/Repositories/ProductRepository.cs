using EDMIL.Communication.Domain.Entity.Product;

namespace EDMIL.Communication.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task Delete(Product aggregate, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Get(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Product aggregate, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product aggregate, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
