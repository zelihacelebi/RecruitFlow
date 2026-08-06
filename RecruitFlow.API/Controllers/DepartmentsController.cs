using Microsoft.AspNetCore.Mvc;
using RecruitFlow.Application.DTOs;
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
        public async Task<IActionResult> GetAll()
        {
            var departments = await _departmentService.GetAllAsync();

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
        public async Task<IActionResult> Create(CreateDepartmentDto dto)
        {
            var createdDepartment = await _departmentService.CreateAsync(dto);

            return Ok(createdDepartment);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateDepartmentDto dto)
        {
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
