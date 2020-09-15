using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Models.Attendance_sheet
{
    //加班申请
   public class Extra_Work:Entity<Guid>
    {
        public new Guid Id { get; set; }//全球唯一标识符
        public Guid Dept_Id { get; set; }//部门外键
        public DateTime ApplyTime { get; set; }//申请时间
        public DateTime Work_StartTime { get; set; }//加班开始时间
        public DateTime Work_EndTime { get; set; }//加班结束时间
        public string Work_Content { get; set; }//加班事由
       

      
    }
}
