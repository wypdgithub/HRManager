using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRManage.Models.AuthorityManagement
{
    /// <summary>
    /// 权限表
    /// </summary>
   public class Power: AuditedAggregateRoot<Guid>
    {
        public Guid Parent_Id { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Desccription { get; set; }
    }
}
