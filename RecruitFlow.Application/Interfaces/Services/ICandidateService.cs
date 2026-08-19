using RecruitFlow.Application.DTOs;
using RecruitFlow.Application.DTOs.Common;


namespace RecruitFlow.Application.Interfaces.Services
{
    public interface ICandidateService
    {
        Task<IEnumerable<CandidateDto>> GetAllAsync(PaginationRequest paginationRequest);
        Task<CandidateDto?> GetByIdAsync(Guid id);

        Task<CandidateDto> CreateAsync(CreateCandidateDto dto);

        Task<CandidateDto> UpdateAsync(Guid id, UpdateCandidateDto dto);

        Task DeleteAsync(Guid id);
    }
}
