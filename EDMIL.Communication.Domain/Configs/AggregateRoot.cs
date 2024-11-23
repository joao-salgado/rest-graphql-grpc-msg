using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMIL.Communication.Domain.Configs
{
    public abstract class AggregateRoot
    {
        public Guid Id { get; protected set; }

        protected AggregateRoot() => Id = Guid.NewGuid();
    }
}
