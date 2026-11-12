using Microsoft.EntityFrameworkCore;
using RecruitFlow.Application.DTOs.Common;
using RecruitFlow.Application.Interfaces.Repositories;
using RecruitFlow.Domain.Entities;
using RecruitFlow.Infrastructure.Data;


namespace RecruitFlow.Infrastructure.Repositories
{
    public class CandidateRepository
     : Repository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Candidate>> GetByQueryAsync(
            QueryRequest queryRequest)
        {
            var query = _context.Candidates.AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryRequest.Search))
            {
                var search = queryRequest.Search.Trim();

                query = query.Where(x =>
                    x.FirstName.Contains(search) ||
                    x.LastName.Contains(search) ||
                    x.Email.Contains(search));
            }

            return await query
                .Skip((queryRequest.Page - 1) * queryRequest.PageSize)
                .Take(queryRequest.PageSize)
                .ToListAsync();
        }
    }
}
