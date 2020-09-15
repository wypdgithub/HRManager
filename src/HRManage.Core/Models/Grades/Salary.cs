using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Models.Grades
{
    /// <summary>
    /// 工资表
    /// </summary>
    public class Salary:AuditedAggregateRoot<Guid>
    {
        public string UserRoleId { get; set; }//用户角色Id
        public decimal Smonery { get; set; }//工资

    }
}
