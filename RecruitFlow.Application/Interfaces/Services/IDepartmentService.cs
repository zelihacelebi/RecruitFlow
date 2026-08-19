using RecruitFlow.Application.DTOs;
using RecruitFlow.Application.DTOs.Common;


namespace RecruitFlow.Application.Interfaces.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentDto>> GetAllAsync(PaginationRequest paginationRequest);
        Task<DepartmentDto?> GetByIdAsync(Guid id);

        Task<DepartmentDto> CreateAsync(CreateDepartmentDto dto);

        Task<DepartmentDto> UpdateAsync(Guid id, UpdateDepartmentDto dto);

        Task DeleteAsync(Guid id);
    }
}
