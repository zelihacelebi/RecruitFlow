using Microsoft.EntityFrameworkCore;
using RecruitFlow.Domain.Entities;


namespace RecruitFlow.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; } = null!;

        public DbSet<JobPosition> JobPositions { get; set; } = null!;

        public DbSet<Candidate> Candidates { get; set; } = null!;
    }
}
