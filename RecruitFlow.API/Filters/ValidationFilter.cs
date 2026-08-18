using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RecruitFlow.API.Filters
{
    public class ValidationFilter<T> : IAsyncActionFilter
    {
        private readonly IValidator<T> _validator;

        public ValidationFilter(IValidator<T> validator)
        {
            _validator = validator;
        }

        public async Task OnActionExecutionAsync(
            ActionExecutingContext context,
            ActionExecutionDelegate next)
        {
            var model = context.ActionArguments
                .Values
                .OfType<T>()
                .FirstOrDefault();

            if (model is not null)
            {
                var validationResult =
                    await _validator.ValidateAsync(model);

                if (!validationResult.IsValid)
                {
                    context.Result = new BadRequestObjectResult(
                        validationResult.Errors
                            .Select(x => new
                            {
                                Property = x.PropertyName,
                                Error = x.ErrorMessage
                            }));

                    return;
                }
            }

            await next();
        }
    }
}
