using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Models.Recruitment
{
    public class EmptryInfo : AuditedAggregateRoot<Guid>
    {
        //public Guid EntId { get; set; } //入职Id
        public string EntPicture { get; set; }//入职者照片
        public string EntPost { get; set; }//入职岗位(外键)
        public DateTime EntTime { get; set; }//入职时间
        public string EntName { get; set; }//入职人姓名
        public string EntPhone { get; set; }//入职人手机号

        public string EntCertificate { get; set; }//入职人证件类型
        public int EntNative { get; set; }//入职人籍贯
        public string EntMarriage { get; set; }//入职人婚姻情况
        public string EntPlace { get; set; }//入职人现居住地
        public DateTime EntPeriod { get; set; }//入职人证件有效期
        public string EntRegister { get; set; }//入职人户籍
        public string EntBirth { get; set; }//入职人生育情况
        public string EntEnglish { get; set; }//入职人英文名
        public int EntSex { get; set; }//入职人性别
        public string EntIdentity { get; set; }//入职人身份证号
        public string EntLocation { get; set; }//入职人户口所在地
        public DateTime EntBirthDay { get; set; }//入职人生日
        public string EntEmergency { get; set; }//入职人紧急联系人
        public string EntFamily { get; set; }//入职人家庭情况
        public string EntWorkExperience { get; set; }//入职人工作经历
        public string EntEducationExperience { get; set; }//入职人教育经历
        public string EntCultivateExperience { get; set; }//入职人培训经历
        public int EntState { get; set; }//入职人面试状态
    }
}
