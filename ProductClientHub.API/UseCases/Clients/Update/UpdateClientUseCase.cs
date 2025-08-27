using Microsoft.AspNetCore.Authentication;
using ProductClientHub.API.Infraestructure;
using ProductClientHub.API.UseCases.Clients.Register;
using ProductClientHub.API.UseCases.Clients.SharedVaildator;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Exceptions.ExceptionsBase;

namespace ProductClientHub.API.UseCases.Clients.Update
{
    public class UpdateClientUseCase
    {
        public void Execute(Guid clientId, RequestClientJson request)
        {
            var dbContext = new ProductClientHubDbContext();

            var entity = dbContext.Clients.FirstOrDefault(client => client.Id == clientId);
            if(entity == null)
            {
                throw new NotFoundException("Cliente não encontrado.");
            }

            entity.Name = request.Name;
            entity.Email = request.Email;

            dbContext.Clients.Update(entity);
            dbContext.SaveChanges();
        }

        private void Validate(RequestClientJson request)
        {
            var validator = new RequestClientValidator();
            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var errors = result.Errors.Select(failure = AuthenticationFailureException.ErrorMessage).ToList();

                throw new ErrorOnValidationException(errors);
            }
        }
    }
}
