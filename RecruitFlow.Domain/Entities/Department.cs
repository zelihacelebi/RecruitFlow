using RecruitFlow.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitFlow.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
    }
}
