using FluentValidation;
using RecruitFlow.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitFlow.Application.Validators
{
    public abstract class DepartmentValidatorBase<T>
       : AbstractValidator<T>
       where T : DepartmentDtoBase
    {
        protected void AddCommonRules()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Departman adı zorunludur.")
                .MaximumLength(100)
                .WithMessage("Departman adı en fazla 100 karakter olabilir.");
        }
    }
    public class CreateDepartmentDtoValidator
    : DepartmentValidatorBase<CreateDepartmentDto>
    {
        public CreateDepartmentDtoValidator()
        {
            AddCommonRules();
        }
    }
    public class UpdateDepartmentDtoValidator
    : DepartmentValidatorBase<UpdateDepartmentDto>
    {
        public UpdateDepartmentDtoValidator()
        {
            AddCommonRules();


            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Department Id zorunludur.");
        }
    }
}
