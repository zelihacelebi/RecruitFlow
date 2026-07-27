using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitFlow.Application.DTOs
{
    public class JobPositionDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public Guid DepartmentId { get; set; }
    }


    public class CreateJobPositionDto   
    {
        public string Title { get; set; } = string.Empty;

        public Guid DepartmentId { get; set; }
    }


    public class UpdateJobPositionDto
    {
        public string Title { get; set; } = string.Empty;

        public Guid DepartmentId { get; set; }
    }
}
