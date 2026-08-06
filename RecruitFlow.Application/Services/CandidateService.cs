using AutoMapper;
using RecruitFlow.Application.DTOs;
using RecruitFlow.Application.Interfaces.Repositories;
using RecruitFlow.Application.Interfaces.Services;
using RecruitFlow.Domain.Entities;


namespace RecruitFlow.Application.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly IMapper _mapper;

        public CandidateService(ICandidateRepository candidateRepository, IMapper mapper)
        {
            _candidateRepository = candidateRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CandidateDto>> GetAllAsync()
        {
            var candidates = await _candidateRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<CandidateDto>>(candidates);
        }
        public async Task<CandidateDto?> GetByIdAsync(Guid id)
        {
            var candidate = await _candidateRepository.GetByIdAsync(id);

            return _mapper.Map<CandidateDto>(candidate);
        }

        public async Task<CandidateDto> CreateAsync(CreateCandidateDto dto)
        {
            var candidate = _mapper.Map<Candidate>(dto);

            await _candidateRepository.AddAsync(candidate);

            return _mapper.Map<CandidateDto>(candidate);
        }

        public async Task<CandidateDto> UpdateAsync(Guid id, UpdateCandidateDto dto)
        {
            var candidate = await _candidateRepository.GetByIdAsync(id);

            if (candidate == null)
                throw new KeyNotFoundException("Candidate not found");

            _mapper.Map(dto, candidate);

            await _candidateRepository.UpdateAsync(candidate);

            return _mapper.Map<CandidateDto>(candidate);
        }
        public async Task DeleteAsync(Guid id)
        {
            var candidate = await _candidateRepository.GetByIdAsync(id);

            if (candidate == null)
                throw new KeyNotFoundException("Candidate not found");

            await _candidateRepository.DeleteAsync(candidate);
        }
    }
}
