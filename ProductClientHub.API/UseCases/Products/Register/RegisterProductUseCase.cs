using ProductClientHub.API.Infraestructure;
using ProductClientHub.API.UseCases.Products.SharedValidator;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;

namespace ProductClientHub.API.UseCases.Products.Register
{
    public class RegisterProductUseCase
    {
        public ResponseShortProductJson Execute(Guid clientId, RequestProductJson request)
        {
            Validate(request);

            var dbContext = new ProductClientHubDbContext();

            var entity = new Product
            {
                Name = request.Name,
                Brand = request.Brand,
                Price = request.Price
            };

            dbContext.Products.Add(entity);
            dbContext.SaveChanges();

            return new ResponseShortProductJson
            {
                Id = entity.Id,
                Name = entity.Name,
            };
        }

        private void Validate(RequestProductJson request)
        {
            var validator = new RequestProductValidator();
            var result = validator.Validate(request);
            if (result.IsValid == false)
            {
                var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();
                throw new ErrorOnValidationException(errors);
            }
        }
    }
}
