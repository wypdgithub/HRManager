using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Models.AuthorityManagement
{
    /// <summary>
    /// 角色权限表
    /// </summary>
    public class RolePower : AuditedAggregateRoot<Guid>
    {
        public Guid Role_Id { get; set; }
        public Guid Power_Id { get; set; }
        public int Type { get; set; }
    }
}
