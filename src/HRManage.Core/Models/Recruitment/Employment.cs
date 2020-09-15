using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Models.Recruitment
{
    public class Employment: AuditedAggregateRoot<Guid>
    {
        public Guid EmpId { get; set; }
    }
}
