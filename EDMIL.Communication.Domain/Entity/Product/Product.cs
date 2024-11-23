using EDMIL.Communication.Domain.Configs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EDMIL.Communication.Domain.Entity.Product
{
    [Table("products")]
    public class Product : AggregateRoot
    {
        [Required]
        [Column("name")]
        public string Name { get; private set; }

        public Product(string name)
        {
            Name = name;
        }
    }
}
