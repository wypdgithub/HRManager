using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Models.Recruitment
{
    public class Employment: AuditedAggregateRoot<Guid>
    {
        //public Guid EmpId { get; set; } //招聘信息Id
        public string EmpTitle { get; set; }//招聘主题
        public string EmpProposer { get; set; }//申请人
        public string EmpDepartment { get; set; }//所属部门(外键)
        public DateTime EmpApplyTime { get; set; }//申请时间
        public string EmpPosition { get; set; }//招聘职位

        public DateTime EmpArrivalTime { get; set; }//希望到岗时间
        public int EmpDemandNumber { get; set; }//需求人数
        public string EmpCauseExplain { get; set; }//招聘原因说明
        public string EmpForeignDemand { get; set; }//外语要求
        public int EmpSex { get; set; }//性别
        public string EmpWorkSite { get; set; }//工作地点
        public int EmpAge { get; set; }//年龄
        public string EmpEducation { get; set; }//学历
        public string EmpWorkExperience { get; set; }//功过经验
        public string EmpWorkContent { get; set; }//功过内容及职责
    }
}
