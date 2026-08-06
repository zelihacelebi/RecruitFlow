using RecruitFlow.Application.DTOs;
using FluentValidation;

namespace RecruitFlow.Application.Validators
{
    public abstract class CandidateValidatorBase<T>
    : AbstractValidator<T>
    where T : CandidateDtoBase
    {
        protected void AddCommonRules()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("Ad alanı zorunludur.")
                .MaximumLength(50)
                .WithMessage("Ad alanı en fazla 50 karakter olabilir.");


            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Soyad alanı zorunludur.")
                .MaximumLength(50)
                .WithMessage("Soyad alanı en fazla 50 karakter olabilir.");


            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email alanı zorunludur.")
                .EmailAddress()
                .WithMessage("Geçerli bir email adresi giriniz.");
        }
    }
    public class CreateCandidateDtoValidator
    : CandidateValidatorBase<CreateCandidateDto>
    {
        public CreateCandidateDtoValidator()
        {
            AddCommonRules();
            RuleFor(x => x.JobPositionId)
                .NotEmpty();
        }
    }


    public class UpdateCandidateDtoValidator
     : CandidateValidatorBase<UpdateCandidateDto>
    {
        public UpdateCandidateDtoValidator()
        {
            AddCommonRules();


            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Candidate Id zorunludur.");


            RuleFor(x => x.JobPositionId)
                .NotEmpty()
                .WithMessage("Pozisyon seçimi zorunludur.");
        }
    }


  
}
