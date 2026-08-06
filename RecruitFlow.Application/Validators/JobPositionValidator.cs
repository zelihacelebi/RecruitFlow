using FluentValidation;
using RecruitFlow.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitFlow.Application.Validators
{
    public abstract class JobPositionValidatorBase<T>
     : AbstractValidator<T>
     where T : JobPositionDtoBase
    {

        protected void AddCommonRules()
        {

            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Pozisyon adı zorunludur.")
                .MaximumLength(100)
                .WithMessage("Pozisyon adı en fazla 100 karakter olabilir.");


            RuleFor(x => x.DepartmentId)
                .NotEmpty()
                .WithMessage("Departman seçimi zorunludur.");

        }
    }
    public class CreateJobPositionDtoValidator
    : JobPositionValidatorBase<CreateJobPositionDto>
    {

        public CreateJobPositionDtoValidator()
        {
            AddCommonRules();
        }

    }
    public class UpdateJobPositionDtoValidator
    : JobPositionValidatorBase<UpdateJobPositionDto>
    {

        public UpdateJobPositionDtoValidator()
        {
            AddCommonRules();


            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("JobPosition Id zorunludur.");
        }

    }
}
