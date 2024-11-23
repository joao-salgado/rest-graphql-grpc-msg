using EDMIL.Communication.Domain.Entity.Product;
using Microsoft.EntityFrameworkCore;

namespace EDMIL.Communication.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CommunicationDBContext _context;

        private DbSet<Product> _products => _context.Set<Product>();

        public ProductRepository(CommunicationDBContext context) => _context = context;

        public Task Delete(Product aggregate, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Get(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Insert(Product aggregate, CancellationToken cancellationToken)
        {
            await _products.AddAsync(aggregate, cancellationToken);
            await _context.SaveChangesAsync();
        }

        public Task Update(Product aggregate, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
