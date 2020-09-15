using Abp.Application.Services.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HRManage.Ping.Dto
{
   public class CreateGradeDto : EntityDto<Guid>
    {
        public Guid GId { get; set; }

        [Required]
        public int GradeAll { get; set; }  //评级
        [Required]

        public int Attenddance { get; set; } //--出勤
        [Required]

        public int Leave { get; set; }     //--请假
        [Required]

        public int Score { get; set; }    // --评分
        [Required]

        public string ChuId { get; set; }    // --出勤Id
        [Required]
        [StringLength(200)]
        public string QingId { get; set; }   /// --请假Id
        [Required]
        [StringLength(200)]
        public string MonthId { get; set; }  // --主管月度
        [Required]
        [StringLength(200)]
        public string YearId { get; set; }    //--主管年度
    }

}
