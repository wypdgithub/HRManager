using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Ping.Dto
{
   public class MonthleadDto : EntityDto<Guid>
    {
        public Guid LId { get; set; }
        public string Duty { get; set; }          //职务
        public string AssessType { get; set; }   //考核类型
        public string Adjunct { get; set; }       //附件
        public int Fidelity { get; set; }          //忠诚度
        public int Approve { get; set; }           //认同感 
        public int Executes { get; set; }          //执行力
        public int Passion { get; set; }           //工作激情
        public int Integrity { get; set; }         //诚信,担责
        public int Familiar { get; set; }          //工作熟悉程度
        public int Learn { get; set; }             //学习能力
        public int Organization { get; set; }      //组织和执行能力
        public int Coopertion { get; set; }        //团队协作能力
        public int Communicate { get; set; }       //协调沟通能力
        public int Accomplish { get; set; }        //每项工作完成情况
        public int Importanc { get; set; }         //重要工作完成率
        public int Satisfaction { get; set; }      //工作满意度
        public int Complaint { get; set; }         //工作投诉率
        public int Figureout { get; set; }         //解决问题
        public int Total { get; set; }             //合计
        public int Selfassessment { get; set; }    //自我评价
        public int Leadevaluaction { get; set; }   //主管评估
        public string UserDepartment { get; set; }    //用户部门Id
    }
}
