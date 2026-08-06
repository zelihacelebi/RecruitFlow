using Microsoft.AspNetCore.Mvc;
using RecruitFlow.Application.DTOs;
using RecruitFlow.Application.Interfaces.Services;

namespace RecruitFlow.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidatesController : ControllerBase
    {
        private readonly ICandidateService _candidateService;

        public CandidatesController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var candidates = await _candidateService.GetAllAsync();

            return Ok(candidates);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var candidate = await _candidateService.GetByIdAsync(id);

            if (candidate == null)
                return NotFound();

            return Ok(candidate);
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateCandidateDto dto)
        {
            var createdCandidate = await _candidateService.CreateAsync(dto);

            return Ok(createdCandidate);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateCandidateDto dto)
        {
            var updatedCandidate = await _candidateService.UpdateAsync(id, dto);

            return Ok(updatedCandidate);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _candidateService.DeleteAsync(id);

            return NoContent();
        }
    }
}
