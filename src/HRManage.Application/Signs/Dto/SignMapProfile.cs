using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using HRManage.Models.Attendance_sheet;
using HRManager.Entitys;

namespace HRManage.Signs.Dto
{
    //封装
    public class SignMapProfile:Profile
    {
        public SignMapProfile()
        {
            CreateMap<SignDto, bool>();
            CreateMap<CreateUpdateSignDto, Sign_In_Tb>();
        }
    }
}
