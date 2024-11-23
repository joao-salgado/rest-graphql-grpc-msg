using EDMIL.Communication.Domain.Entity.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMIL.Communication.Application.UseCases.Product.List
{
    public class ListProduct : IListProduct
    {
        private readonly IProductRepository _productRepository;

        public ListProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductResponse>> Handle(CancellationToken cancellationToken)
        {
            var products = await _productRepository.List(cancellationToken);

            return products
                .Select(product => new ProductResponse(product.Id, product.Name))
                .ToList();
        }
    }
}
