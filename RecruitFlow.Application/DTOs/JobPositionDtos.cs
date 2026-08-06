using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitFlow.Application.DTOs
{
    public class JobPositionDtoBase
    {
        public string Title { get; set; } = string.Empty;

        public Guid DepartmentId { get; set; }
    }
    public class JobPositionDto : JobPositionDtoBase
    {
        public Guid Id { get; set; }
    }

    public class CreateJobPositionDto : JobPositionDtoBase
    {
    }

    public class UpdateJobPositionDto : JobPositionDtoBase
    {
        public Guid Id { get; set; }
    }
}
