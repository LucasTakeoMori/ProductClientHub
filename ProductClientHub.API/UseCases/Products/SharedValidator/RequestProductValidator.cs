using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Products.SharedValidator
{
    public class RequestProductValidator : AbstractValidator<RequestProductJson>
    {
        public RequestProductValidator() {
            RuleFor(product => product.Name).NotEmpty().WithMessage("The name cannot be empty.");
            RuleFor(product => product.Brand).NotEmpty().WithMessage("The Brand cannot be empty.");
            RuleFor(product => product.Price).GreaterThan(0).WithMessage("The price for this product is invalid.");
        }
    }
}
