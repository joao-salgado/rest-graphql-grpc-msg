using EDMIL.Communication.Application.UseCases.Product.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMIL.Communication.Application.UseCases.Product.List
{
    public interface IListProduct
    {
        public Task<List<ProductResponse>> Handle(CancellationToken cancellationToken);
    }
}
