using RecruitFlow.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitFlow.Domain.Entities
{
    public class JobPosition: BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
