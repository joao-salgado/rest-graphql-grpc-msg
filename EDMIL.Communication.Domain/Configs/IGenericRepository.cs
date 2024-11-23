using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMIL.Communication.Domain.Configs
{
    public interface IGenericRepository<TAggregate> where TAggregate : AggregateRoot
    {
        public Task Insert(TAggregate aggregate, CancellationToken cancellationToken);
        public Task<TAggregate> Get(Guid id, CancellationToken cancellationToken);
        public Task Delete(TAggregate aggregate, CancellationToken cancellationToken);
        public Task Update(TAggregate aggregate, CancellationToken cancellationToken);
    }
}
