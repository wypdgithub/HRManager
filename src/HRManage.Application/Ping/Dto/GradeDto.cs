using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Ping.Dto
{
   public class GradeDto : EntityDto<Guid>
    {
        public Guid GId { get; set; }
        public int GradeAll { get; set; }  //评级
        public int Attenddance { get; set; } //--出勤
        public int Leave { get; set; }     //--请假
        public int Score { get; set; }    // --评分
        public string ChuId { get; set; }    // --出勤Id
        public string QingId { get; set; }   /// --请假Id
        public string MonthId { get; set; }  // --主管月度
        public string YearId { get; set; }    //--主管年度
    }
}
