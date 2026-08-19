using AutoMapper;
using RecruitFlow.Application.DTOs;
using RecruitFlow.Application.DTOs.Common;
using RecruitFlow.Application.Interfaces.Repositories;
using RecruitFlow.Application.Interfaces.Services;
using RecruitFlow.Domain.Entities;


namespace RecruitFlow.Application.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public DepartmentService(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DepartmentDto>> GetAllAsync(PaginationRequest paginationRequest)
        {
            var departments = await _departmentRepository.GetAllAsync(paginationRequest);

            return _mapper.Map<IEnumerable<DepartmentDto>>(departments);
        }
        public async Task<DepartmentDto?> GetByIdAsync(Guid id)
        {
            var department = await _departmentRepository.GetByIdAsync(id);

            return _mapper.Map<DepartmentDto>(department);
        }

        public async Task<DepartmentDto> CreateAsync(CreateDepartmentDto dto)
        {
            var department = _mapper.Map<Department>(dto);

            await _departmentRepository.AddAsync(department);

            return _mapper.Map<DepartmentDto>(department);
        }

        public async Task<DepartmentDto> UpdateAsync(Guid id, UpdateDepartmentDto dto)
        {
            var department = await _departmentRepository.GetByIdAsync(id);

            if (department == null)
                throw new KeyNotFoundException("Department not found");

            _mapper.Map(dto, department);

            await _departmentRepository.UpdateAsync(department);

            return _mapper.Map<DepartmentDto>(department);
        }
        public async Task DeleteAsync(Guid id)
        {
            var department = await _departmentRepository.GetByIdAsync(id);

            if (department == null)
                throw new KeyNotFoundException("Department not found");

            await _departmentRepository.DeleteAsync(department);
        }
    }
}
