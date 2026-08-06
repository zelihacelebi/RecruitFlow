
namespace RecruitFlow.Application.DTOs
{
    public abstract class CandidateDtoBase
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }

    public class CandidateDto : CandidateDtoBase
    {
        public Guid Id { get; set; }

        public Guid JobPositionId { get; set; }
    }


    public class CreateCandidateDto : CandidateDtoBase
    {
        public Guid JobPositionId { get; set; }
    }


    public class UpdateCandidateDto : CandidateDtoBase
    {
        public Guid Id { get; set; }

        public Guid JobPositionId { get; set; }
    }
}
