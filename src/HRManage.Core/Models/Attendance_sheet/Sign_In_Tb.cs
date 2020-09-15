using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRManager.Entitys
{
    //签到表
   public class Sign_In_Tb:Entity<Guid>,IHasCreationTime
    {
        
        public new Guid Id { get; set; }
        public int UserId { get; set; }//用户外键
        [StringLength(30)]
        public string UserName { get; set; }//用户名称
        [StringLength(50)]
        public string sign_In_Number { get; set; }//考勤号码
        public DateTime sign_In_Date { get; set; }//打卡日期
        [StringLength(50)]
        public string sign_In_Day { get; set; }//星期（周几）
        [StringLength(50)]
        public string sign_In_Shift_Name { get; set; }//班次名称
        public DateTime sign_In_Mor_StartTime { get; set; }//上午签到时间
        public DateTime sign_In_Mor_EndTime { get; set; }//下午签退时间
        public DateTime sign_In_Aft_StartTime { get; set; }//下午签到时间
        public DateTime sign_In_Aft_EndTime { get; set; }//下午签退时间
        [StringLength(50)]
        public string department { get; set; }//部门
        public int sign_In_Mor_States { get; set; }//上午打卡状态
        public int sign_In_Aft_States { get; set; }//下午打卡状态

        public DateTime CreationTime { get; set; }
    }
}
