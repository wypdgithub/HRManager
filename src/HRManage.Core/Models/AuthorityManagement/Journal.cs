using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Models.AuthorityManagement
{
    /// <summary>
    /// 日志表
    /// </summary>
    public class Journal : AuditedAggregateRoot<Guid>
    {
        public string Content { get; set; }
        public Guid User_Id { get; set; }
    }
}
