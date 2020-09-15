using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.All.Please_Leaves.Dto
{
   public class Please_LeaveDto:Entity<Guid>
    {
        public new Guid Id { get; set; }//全球唯一标识符
    
        public string Proposer { get; set; }//申请人
        public DateTime ApplyTime { get; set; }//申请时间
        public DateTime Please_leave_SatrtTime { get; set; }//请休假开始时间
        public DateTime Please_leave_EndTime { get; set; }//结束时间
        public Guid Please_leave_TypeId { get; set; }//请假类型外键
        public Guid Dept_Id { get; set; }//部门外键
        public string Business_Reason { get; set; }//请假原因
        public int States { get; set; }//请假审核状态
    }
}
