using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;

namespace HRManage.Models.AuthorityManagement
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class Role : AuditedAggregateRoot<Guid>
    {
        public Guid Parent_Id { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Desccription { get; set; }
    }
}
