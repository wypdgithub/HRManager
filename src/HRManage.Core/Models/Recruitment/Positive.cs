using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Models.Recruitment
{
    public class Positive : AuditedAggregateRoot<Guid>
    {
        //public Guid PosId { get; set; } //招聘信息Id
        public string PosTitle { get; set; }//主题
        public string PosPriority { get; set; }//优先级
        public string PosProcess { get; set; }//步骤
        public string PosPop { get; set; }//入职人(外键)
        public int PosAffiliated { get; set; }//所属部门

        public DateTime PosTime { get; set; }//申请时间
        public string PosPost { get; set; }//申请岗位
        public DateTime PosEntryTime { get; set; }//入职日期
        public DateTime PosPosiTime { get; set; }//转正日期
        public string PosJoinContent { get; set; }//试用期工作内容
        public string PosJoinScore { get; set; }//试用期工作成绩
        public string PosContent { get; set; }//试用期存在的问题
        public string PosThought { get; set; }//问题的改进设想
        public string PosChargeContent { get; set; }//主管评语
        public string PosLoderContent { get; set; }//领导评语
        public string EntAffix { get; set; }//附件
        public string EntHandle { get; set; }//处理过程
    }
}
