using EDMIL.Communication.Application.UseCases.Product;
using EDMIL.Communication.Application.UseCases.Product.Create;
using EDMIL.Communication.Application.UseCases.Product.List;
using EDMIL.Communication.Infra.Controllers.Api.ApiModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDMIL.Communication.Infra.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ICreateProduct _createProduct;
        private readonly IListProduct _listProduct;

        public ProductsController(
            ICreateProduct createProduct, 
            IListProduct listProduct
        )
        {
            _createProduct = createProduct;
            _listProduct = listProduct;
        }

        [HttpPost]
        public async Task<IActionResult> Create(
            [FromBody] CreateProductRequest request,
            CancellationToken cancellationToken
        )
        {
            var output = await _createProduct.Handle(request, cancellationToken);

            return CreatedAtAction(
                nameof(Create),
                new { output.Id },
                new ApiResponse<ProductResponse>(output)
            );
        }

        [HttpGet]
        public async Task<IActionResult> List(
            CancellationToken cancellationToken
        )
        {
            var output = await _listProduct.Handle(cancellationToken);

            return Ok(
                new ApiResponse<List<ProductResponse>>(output)
            );
        }

    }
}
