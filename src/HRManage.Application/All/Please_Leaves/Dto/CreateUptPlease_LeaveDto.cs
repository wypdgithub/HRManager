using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRManage.All.Please_Leaves.Dto
{
   public class CreateUptPlease_LeaveDto:EntityDto<Guid>
    {
        public new Guid Id { get; set; }//全球唯一标识符
        [Required]
        [StringLength(100)]
        public string Proposer { get; set; }//申请人
        //申请时间
        public DateTime ApplyTime { get; set; } = DateTime.Now;//默认当前系统时间
        [Required]
        public DateTime Please_leave_SatrtTime { get; set; }//请休假开始时间
        [Required]
        public DateTime Please_leave_EndTime { get; set; }//结束时间
        [Required]
        public Guid Please_leave_TypeId { get; set; }//请假类型外键
        [Required]
        public Guid Dept_Id { get; set; }//部门外键
        [Required]
        [StringLength(500)]
        public string Business_Reason { get; set; }//请假原因
        
        public int States { get; set; }//请假审核状态
    }
}
