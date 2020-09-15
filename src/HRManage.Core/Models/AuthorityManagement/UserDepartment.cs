using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Models.AuthorityManagement
{
    /// <summary>
    /// 用户部门表
    /// </summary>
   public class UserDepartment : AuditedAggregateRoot<Guid>
    {
        public Guid User_Id { get; set; }
        public Guid Department_Id { get; set; }
    }
}
