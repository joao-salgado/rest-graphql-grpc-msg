namespace EDMIL.Communication.Application.UseCases.Product.Create
{
    public interface ICreateProduct
    {
        public Task<ProductResponse> Handle(CreateProductRequest request, CancellationToken cancellationToken);
    }
}
