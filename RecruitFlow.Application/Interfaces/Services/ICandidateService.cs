using RecruitFlow.Application.DTOs;


namespace RecruitFlow.Application.Interfaces.Services
{
    public interface ICandidateService
    {
        Task<IEnumerable<CandidateDto>> GetAllAsync();
        Task<CandidateDto?> GetByIdAsync(Guid id);

        Task<CandidateDto> CreateAsync(CreateCandidateDto dto);

        Task UpdateAsync(Guid id, UpdateCandidateDto dto);

        Task DeleteAsync(Guid id);
    }
}
