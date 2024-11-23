namespace EDMIL.Communication.Application.UseCases.Product
{
    public class ProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ProductResponse(
            Guid id,
            string name
        )
        {
            Id = id;
            Name = name;
        }
    }
}
