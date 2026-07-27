using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitFlow.Domain.Entities
{
    public class Candidate : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;


        public Guid JobPositionId { get; set; }

        public JobPosition JobPosition { get; set; } = null!;
    }
}
