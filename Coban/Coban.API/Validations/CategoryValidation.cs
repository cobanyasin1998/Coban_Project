using Coban.DTO;
using FluentValidation;

namespace Coban.API.Validations
{
    public class CreateUserDTOValidator : AbstractValidator<CategoryDTO>
    {
        public CreateUserDTOValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Name is required").MinimumLength(3).WithMessage("Name is minimum length 3");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Description is required");

        }
    }
}
