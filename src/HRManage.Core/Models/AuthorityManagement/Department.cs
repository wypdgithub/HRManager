using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRManage.Models.AuthorityManagement
{
    /// <summary>
    /// 部门表
    /// </summary>
    public class Department : AuditedAggregateRoot<Guid>
    {
        [StringLength(20)]
        public string Name { get; set; }
    }
}
