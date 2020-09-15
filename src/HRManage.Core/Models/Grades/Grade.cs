using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Models.Grade
{
    public  class Grade:Entity<Guid>
    {
        public int GradeAll { get; set; }  //评级
        public int Attenddance { get; set; } //--出勤
        public int Leave { get; set; }     //--请假
        public int Score { get; set; }    // --评分
        public int ChuId { get; set; }    // --出勤Id
        public string QingId { get; set; }   /// --请假Id
        public string MonthId { get; set; }  // --主管月度
        public string YearId  { get; set; }    //--主管年度
    }
}
