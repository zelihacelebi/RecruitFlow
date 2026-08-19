using RecruitFlow.Application.DTOs;
using RecruitFlow.Application.DTOs.Common;


namespace RecruitFlow.Application.Interfaces.Services
{
    public interface IJobPositionService
    {
        Task<IEnumerable<JobPositionDto>> GetAllAsync(PaginationRequest paginationRequest);
        Task<JobPositionDto?> GetByIdAsync(Guid id);

        Task<JobPositionDto> CreateAsync(CreateJobPositionDto dto);

        Task<JobPositionDto> UpdateAsync(Guid id, UpdateJobPositionDto dto);

        Task DeleteAsync(Guid id);
    }
}
