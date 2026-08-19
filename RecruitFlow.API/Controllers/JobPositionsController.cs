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
    public class JobPositionsController : ControllerBase
    {
        private readonly IJobPositionService _jobPositionService;

        public JobPositionsController(IJobPositionService jobPositionService)
        {
            _jobPositionService = jobPositionService;
        }

        [HttpGet]
        [ServiceFilter(typeof(ValidationFilter<PaginationRequest>))]
        public async Task<IActionResult> GetAll([FromQuery] PaginationRequest paginationRequest)
        {
            var jobPositions = await _jobPositionService.GetAllAsync(paginationRequest);

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
        [ServiceFilter(typeof(ValidationFilter<CreateJobPositionDto>))]
        public async Task<IActionResult> Create(CreateJobPositionDto dto)
        {
            var createdJobPosition = await _jobPositionService.CreateAsync(dto);

            return Ok(createdJobPosition);
        }


        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilter<CreateJobPositionDto>))]
        public async Task<IActionResult> Update(Guid id, UpdateJobPositionDto dto)
        {
            dto.Id = id;
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
