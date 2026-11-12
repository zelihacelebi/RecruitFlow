using FluentValidation;
using RecruitFlow.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitFlow.Application.Validators
{
    public class QueryRequestValidator : AbstractValidator<QueryRequest>
    {
        public QueryRequestValidator()
        {
            RuleFor(x => x.Page)
                .GreaterThanOrEqualTo(1)
                .WithMessage("Page must be greater than or equal to 1.");

            RuleFor(x => x.PageSize)
                .InclusiveBetween(1, 100)
                .WithMessage("PageSize must be between 1 and 100.");

            RuleFor(x => x.SortDirection)
                .Must(x =>
                    string.IsNullOrWhiteSpace(x) ||
                    x.Equals("asc", StringComparison.OrdinalIgnoreCase) ||
                    x.Equals("desc", StringComparison.OrdinalIgnoreCase))
                .WithMessage("SortDirection must be 'asc' or 'desc'.");
        }
    }
}
