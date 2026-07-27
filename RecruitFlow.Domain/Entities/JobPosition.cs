using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitFlow.Domain.Entities
{

    public class JobPosition : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;


        public Guid DepartmentId { get; set; }

        public Department Department { get; set; } = null!;


        public ICollection<Candidate> Candidates { get; set; } = new List<Candidate>();
    }
}
