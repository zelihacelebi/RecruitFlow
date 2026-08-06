using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitFlow.Application.DTOs
{
    public abstract class DepartmentDtoBase
    {
        public string Name { get; set; } = string.Empty;
    }
    public class DepartmentDto : DepartmentDtoBase
    {
        public Guid Id { get; set; }
    }


    public class CreateDepartmentDto : DepartmentDtoBase
    {
    }


    public class UpdateDepartmentDto : DepartmentDtoBase
    {
        public Guid Id { get; set; }
    }

}
