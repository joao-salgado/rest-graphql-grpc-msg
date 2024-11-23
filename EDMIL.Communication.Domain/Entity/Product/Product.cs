using EDMIL.Communication.Domain.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EDMIL.Communication.Domain.Entity.Product
{
    public class Product : AggregateRoot
    {
        public string Name { get; private set; }

        public Product(string name)
        {
            Name = name;
        }
    }
}
