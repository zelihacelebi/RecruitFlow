using RecruitFlow.Application.Interfaces;
using RecruitFlow.Domain.Entities;
using RecruitFlow.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitFlow.Infrastructure.Repositories
{
    public class DepartmentRepository
        : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
