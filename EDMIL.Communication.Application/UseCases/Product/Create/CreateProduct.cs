using EDMIL.Communication.Domain.Entity.Product;
using DomainEntity = EDMIL.Communication.Domain.Entity;

namespace EDMIL.Communication.Application.UseCases.Product.Create
{
    public class CreateProduct : ICreateProduct
    {
        private readonly IProductRepository _productRepository;

        public CreateProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductResponse> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            var product = new DomainEntity.Product.Product(
                request.Name
            );

            await _productRepository.Insert(product, cancellationToken);

            return new ProductResponse(product.Id, product.Name);
        }
    }
}
