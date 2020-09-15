using Abp.Application.Services.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HRManage.Ping.Dto
{
   public class CreatMonthstaffDto : EntityDto<Guid>
    {
        public Guid SId { get; set; }
        [Required]
        [StringLength(200)]
        public string Duty { get; set; }          //职务
        [Required]
        [StringLength(200)]
        public string AssessType { get; set; }   //考核类型
        [Required]
        [StringLength(200)]
        public string Adjunct { get; set; }       //附件
        [Required]
        public int Fidelity { get; set; }          //忠诚度
        [Required]
        public int Approve { get; set; }           //认同感 
        [Required]
        public int Executes { get; set; }          //执行力
        [Required]
        public int Passion { get; set; }           //工作激情
        [Required]
        public int Integrity { get; set; }         //诚信,担责
        [Required]
        public int Familiar { get; set; }          //工作熟悉程度
        [Required]
        public int Learn { get; set; }             //学习能力
        [Required]
        public int Organization { get; set; }      //组织和执行能力
        [Required]
        public int Coopertion { get; set; }        //团队协作能力
        [Required]
        public int Communicate { get; set; }       //协调沟通能力
        [Required]
        public int Accomplish { get; set; }        //每项工作完成情况
        [Required]
        public int Importanc { get; set; }         //重要工作完成率
        [Required]
        public int Satisfaction { get; set; }      //工作满意度
        [Required]
        public int Complaint { get; set; }         //工作投诉率
        [Required]
        public int Figureout { get; set; }         //解决问题
        [Required]
        public int Total { get; set; }             //合计
        [Required]
        public int Selfassessment { get; set; }    //自我评价
        [Required]
        public int Leadevaluaction { get; set; }   //主管评估
        [Required]
        [StringLength(200)]
        public string UserDepartment { get; set; }    //用户部门Id
    }
}
