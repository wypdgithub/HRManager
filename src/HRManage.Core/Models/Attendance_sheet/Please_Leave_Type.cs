using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRManage.Models.Attendance_sheet
{
    //请假类型表
   public class Please_Leave_Type:Entity<Guid>
    {
        public new Guid Id { get; set; }//全球唯一标识符
        [StringLength(50)]
        public string Please_leave_Name { get; set; }  //请假类型名称
      
    }
}
