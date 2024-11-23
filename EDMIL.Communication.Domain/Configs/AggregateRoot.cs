using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMIL.Communication.Domain.Configs
{
    public abstract class AggregateRoot
    {
        [Key]
        [Column("id")]
        public Guid Id { get; protected set; }

        protected AggregateRoot() => Id = Guid.NewGuid();
    }
}
