using RecruitFlow.Application.Interfaces.Repositories;
using RecruitFlow.Application.Interfaces.Services;
using RecruitFlow.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitFlow.Application.Services
{
    public class JobPositionService : IJobPositionService   
    {
        private readonly IJobPositionRepository _jobPositionRepository;

        public JobPositionService(IJobPositionRepository jobPositionRepository)
        {
            _jobPositionRepository = jobPositionRepository;
        }

        public async Task<IEnumerable<JobPosition>> GetAllAsync()
        {
            return await _jobPositionRepository.GetAllAsync();
        }
    }
}
