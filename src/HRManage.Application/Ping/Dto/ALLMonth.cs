using AutoMapper;
using HRManage.Models.Grade;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.Ping.Dto
{
   public class ALLMonth:Profile
    {
        public ALLMonth()
        {
            CreateMap<GradeDto, Grade>();
            CreateMap<CreateGradeDto, Grade>();

            CreateMap<MonthleadDto, Monthlead>();
            CreateMap<CreatMonthleadDto, Monthlead>();

            CreateMap<MonthstaffDto, Monthstaff>();
            CreateMap<CreatMonthstaffDto, Monthstaff>();
        }
    }
}
