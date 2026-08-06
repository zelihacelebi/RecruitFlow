using Microsoft.AspNetCore.Mvc;
using RecruitFlow.Application.DTOs;
using RecruitFlow.Application.Interfaces.Services;
using RecruitFlow.Application.Services;

namespace RecruitFlow.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobPositionsController : ControllerBase
    {
        private readonly IJobPositionService _jobPositionService;

        public JobPositionsController(IJobPositionService jobPositionService)
        {
            _jobPositionService = jobPositionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var jobPositions = await _jobPositionService.GetAllAsync();

            return Ok(jobPositions);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var jobPosition = await _jobPositionService.GetByIdAsync(id);

            if (jobPosition == null)
                return NotFound();

            return Ok(jobPosition);
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateJobPositionDto dto)
        {
            var createdJobPosition = await _jobPositionService.CreateAsync(dto);

            return Ok(createdJobPosition);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateJobPositionDto dto)
        {
            var updatedJobPosition = await _jobPositionService.UpdateAsync(id, dto);

            return Ok(updatedJobPosition);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _jobPositionService.DeleteAsync(id);

            return NoContent();
        }
    }
}
