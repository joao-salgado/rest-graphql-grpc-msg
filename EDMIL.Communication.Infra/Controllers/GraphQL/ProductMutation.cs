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
        public async Task<ProductResponse> CreateProduct(
            string name,
            [Service] ICreateProduct _createProduct
        )
        {
            var output = await _createProduct.Handle(new CreateProductRequest(name), CancellationToken.None);

            return new ProductResponse(output.Id, output.Name);
        }
    }
}
