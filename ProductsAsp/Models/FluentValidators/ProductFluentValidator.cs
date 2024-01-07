using FluentValidation;

namespace ProductsAsp.Models.FluentValidators
{
    public class ProductFluentValidator : AbstractValidator<Product>
    {

        public ProductFluentValidator()
        {
            RuleFor(p=>p.ProductName)
                .NotEmpty().WithMessage("Product Name is required.")
                .MaximumLength(50).WithMessage("Product Name cannot exceed 50 characters.");

            RuleFor(p=>p.Description)
                .NotEmpty().WithMessage("Description is required.")
                .MaximumLength(200).WithMessage("Description cannot exceed 200 characters.");

            RuleFor(p=>p.Price)
                .NotNull().WithMessage("Price is required.")
                .Must(check).WithMessage("Price must be a numeric value.")
                .GreaterThan(0).WithMessage("Price must be greater than zero.");
        }
        private bool check(double value)
        {
            return true;
        }
    }
}
