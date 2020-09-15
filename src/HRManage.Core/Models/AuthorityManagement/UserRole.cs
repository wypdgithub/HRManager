using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Models.AuthorityManagement
{
    /// <summary>
    /// 用户角色表
    /// </summary>
   public class UserRole : AuditedAggregateRoot<Guid>
    {
        public Guid Role_Id { get; set; }
        public Guid User_Id { get; set; }
        public int Type { get; set; }
    }
}
