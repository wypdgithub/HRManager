using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRManage.Models.Attendance_sheet
{
    //出差申请表
  public  class Evection:Entity<Guid>
    {
        public new Guid Id { get; set; }// 全球唯一标识符
        public string Proposer { get; set; }//申请人
        public DateTime ApplyTime { get; set; }//申请时间
        [StringLength(50)]
        public string Site { get; set; }//外出地点
        public DateTime Business_StartTime { get; set; }//外出时间
        public DateTime Business_EndTime { get; set; }//结束时间
        public string Business_Content { get; set; }//出差事由
        public Boolean Vehicle { get; set; }//交通工具
        public Guid Dept_Id { get; set; }//部门外键
      
    }
}
