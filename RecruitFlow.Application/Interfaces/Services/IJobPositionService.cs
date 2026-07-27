using RecruitFlow.Domain;
using RecruitFlow.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitFlow.Application.Interfaces.Services
{
    public interface IJobPositionService
    {
        Task<IEnumerable<JobPosition>> GetAllAsync();
    }
}
