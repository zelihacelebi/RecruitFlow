using Microsoft.AspNetCore.Mvc;
using RecruitFlow.API.Filters;
using RecruitFlow.Application.DTOs;
using RecruitFlow.Application.DTOs.Common;
using RecruitFlow.Application.Interfaces.Services;
using RecruitFlow.Application.Services;

namespace RecruitFlow.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        [ServiceFilter(typeof(ValidationFilter<PaginationRequest>))]
        public async Task<IActionResult> GetAll([FromQuery] PaginationRequest paginationRequest)
        {
            var departments = await _departmentService.GetAllAsync(paginationRequest);

            return Ok(departments);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var department = await _departmentService.GetByIdAsync(id);

            if (department == null)
                return NotFound();

            return Ok(department);
        }


        [HttpPost]
        [ServiceFilter(typeof(ValidationFilter<CreateDepartmentDto>))]
        public async Task<IActionResult> Create(CreateDepartmentDto dto)
        {
            var createdDepartment = await _departmentService.CreateAsync(dto);

            return Ok(createdDepartment);
        }


        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilter<CreateDepartmentDto>))]
        public async Task<IActionResult> Update(Guid id, UpdateDepartmentDto dto)
        {
            dto.Id = id;
            var updatedDepartment = await _departmentService.UpdateAsync(id, dto);

            return Ok(updatedDepartment);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _departmentService.DeleteAsync(id);

            return NoContent();
        }
    }
}
