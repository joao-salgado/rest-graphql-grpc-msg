using EDMIL.Communication.Application.UseCases.Product;
using EDMIL.Communication.Application.UseCases.Product.Create;
using EDMIL.Communication.Infra.Controllers.ApiModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDMIL.Communication.Infra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ICreateProduct _createProduct;

        public ProductsController(ICreateProduct createProduct)
        {
            _createProduct = createProduct;
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

    }
}
