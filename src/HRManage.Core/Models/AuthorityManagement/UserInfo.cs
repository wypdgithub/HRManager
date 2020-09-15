using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRManage.Models.AuthorityManagement
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class UserInfo : AuditedAggregateRoot<Guid>
    {
        [StringLength(64)]
        public string Login_Name { get; set; }
        [StringLength(64)]
        public string PassWord { get; set; }
        [StringLength(64)]
        public string UserName { get; set; }
        [StringLength(64)]
        public string Mobile { get; set; }
        [StringLength(64)]
        public string Email { get; set; }
        [StringLength(64)]
        public string State { get; set; }
    }
}
