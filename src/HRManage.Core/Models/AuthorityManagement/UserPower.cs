using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Models.AuthorityManagement
{
    /// <summary>
    /// 用户权限表
    /// </summary>
    public class UserPower: AuditedAggregateRoot<Guid>
    {
        public Guid User_Id { get; set; }
        public Guid Power_Id { get; set; }
        public int Type { get; set; }
    }
}
