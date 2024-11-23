namespace EDMIL.Communication.Application.UseCases.Product.Create
{
    public class CreateProductRequest
    {
        public string Name { get; set; }

        public CreateProductRequest(string name)
        {
            Name = name;
        }
    }
}
