using AutoMapper;
using HRManage.Models.Attendance_sheet;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.All.KQ.Dto
{
  public  class DetailedMapProfile:Profile
    {
        public DetailedMapProfile()
        {
            CreateMap<DetailedDto, Detailed>();
            CreateMap<CreateUptDetailedDto, Detailed>();
        }
    }
}
