using AutoMapper;
using RecruitFlow.Application.DTOs;
using RecruitFlow.Application.Interfaces.Repositories;
using RecruitFlow.Application.Interfaces.Services;
using RecruitFlow.Domain.Entities;


namespace RecruitFlow.Application.Services
{
    public class JobPositionService : IJobPositionService   
    {
        private readonly IJobPositionRepository _jobPositionRepository;
        private readonly IMapper _mapper;

        public JobPositionService(IJobPositionRepository jobPositionRepository, IMapper mapper)
        {
            _jobPositionRepository = jobPositionRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<JobPositionDto>> GetAllAsync()
        {
            var jobPositions = await _jobPositionRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<JobPositionDto>>(jobPositions);
        }
        public async Task<JobPositionDto?> GetByIdAsync(Guid id)
        {
            var jobPosition = await _jobPositionRepository.GetByIdAsync(id);

            return _mapper.Map<JobPositionDto>(jobPosition);
        }

        public async Task<JobPositionDto> CreateAsync(CreateJobPositionDto dto)
        {
            var jobPosition = _mapper.Map<JobPosition>(dto);

            await _jobPositionRepository.AddAsync(jobPosition);

            return _mapper.Map<JobPositionDto>(jobPosition);
        }

        public async Task UpdateAsync(Guid id, UpdateJobPositionDto dto)
        {
            var jobPosition = await _jobPositionRepository.GetByIdAsync(id);

            if (jobPosition == null)
                throw new KeyNotFoundException("Job position not found");

            _mapper.Map(dto, jobPosition);

            _jobPositionRepository.Update(jobPosition);
        }
        public async Task DeleteAsync(Guid id)
        {
            var jobPosition = await _jobPositionRepository.GetByIdAsync(id);

            if (jobPosition == null)
                throw new KeyNotFoundException("Job position not found");

            _jobPositionRepository.Delete(jobPosition);
        }
    }
}
