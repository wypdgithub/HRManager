using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Models.Attendance_sheet
{
    //详细表
   public class Detailed:Entity<Guid>
    {
        public new  Guid Id { get; set; }//全球唯一标识符
        public  Guid sign_In_Id { get; set; }//签到表外键
        public int beLate { get; set; }//迟到
        public int leaveEarly { get; set; }//早退
        public int sickLeave { get; set; }//病假
        public int absenteeism { get; set; }//旷工
        public int marriage_Leave { get; set; }//婚假
        public int funeral_leave { get; set; }//丧假
        public int maternity_Leave { get; set; }//产假
        public int affair_Leave { get; set; }//事假
        public int official_Business { get; set; }//公事
        public DateTime ShouldBe { get; set; }//应出勤
        public DateTime RealBe { get; set; }//实际出勤
        public int forget { get; set; }//忘记打卡
      
    }
}
