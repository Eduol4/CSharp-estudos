using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Products.SharedValidator
{
    public class RequestProductValidator : AbstractValidator<RequestProductJson>
    {
        public RequestProductValidator()
        {
            RuleFor(product => product.Name).NotEmpty().WithMessage("Nome do produto inválido.");
            RuleFor(product => product.Name).NotEmpty().WithMessage("Nome do produto inválido.");
        }
    }
}
