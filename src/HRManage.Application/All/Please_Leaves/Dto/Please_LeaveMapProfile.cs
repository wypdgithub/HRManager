using AutoMapper;
using HRManage.Models.Attendance_sheet;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.All.Please_Leaves.Dto
{
    class Please_LeaveMapProfile:Profile
    {
        public Please_LeaveMapProfile()
        {
            CreateMap<Please_LeaveDto, Please_Leave>();
            CreateMap<CreateUptPlease_LeaveDto, Please_Leave>();
        }
    }
}
