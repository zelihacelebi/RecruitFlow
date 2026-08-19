using RecruitFlow.Application.DTOs.Common;
using FluentValidation;

namespace RecruitFlow.Application.Validators
{
    public class PaginationRequestValidator : AbstractValidator<PaginationRequest>
    {
        public PaginationRequestValidator()
        {
            RuleFor(x => x.Page)
                  .GreaterThanOrEqualTo(1)
                  .WithMessage("Page must be greater than or equal to 1.");

            RuleFor(x => x.PageSize)
            .InclusiveBetween(1, 100)
            .WithMessage("PageSize must be between 1 and 100.");
        }
    }
}
