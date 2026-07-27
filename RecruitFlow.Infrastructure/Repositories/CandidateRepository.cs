using RecruitFlow.Application.Interfaces.Repositories;
using RecruitFlow.Domain.Entities;
using RecruitFlow.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitFlow.Infrastructure.Repositories
{
    public class CandidateRepository
     : Repository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
