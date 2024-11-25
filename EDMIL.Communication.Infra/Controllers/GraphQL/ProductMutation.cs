using EDMIL.Communication.Application.UseCases.Product;
using EDMIL.Communication.Application.UseCases.Product.Create;
using EDMIL.Communication.Application.UseCases.Product.List;
using EDMIL.Communication.Domain.Entity.Product;
using EDMIL.Communication.Infra.Controllers.Api.ApiModels;
using EDMIL.Communication.Infra.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace EDMIL.Communication.Infra.Controllers.GraphQL
{
    public class ProductMutation
    {
        private readonly ICreateProduct _createProduct;

        public ProductMutation(
           ICreateProduct createProduct
        )
        {
            _createProduct = createProduct;
        }
        public async Task<ApiResponse<ProductResponse>> CreateProduct(
            [FromBody] CreateProductRequest request,
            CancellationToken cancellationToken
        )
        {
            var output = await _createProduct.Handle(request, cancellationToken);

            return new ApiResponse<ProductResponse>(output);
        }
    }
}
