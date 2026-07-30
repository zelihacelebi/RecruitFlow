using RecruitFlow.Application.DTOs;


namespace RecruitFlow.Application.Interfaces.Services
{
    public interface IJobPositionService
    {
        Task<IEnumerable<JobPositionDto>> GetAllAsync();
        Task<JobPositionDto?> GetByIdAsync(Guid id);

        Task<JobPositionDto> CreateAsync(CreateJobPositionDto dto);

        Task UpdateAsync(Guid id, UpdateJobPositionDto dto);

        Task DeleteAsync(Guid id);
    }
}
