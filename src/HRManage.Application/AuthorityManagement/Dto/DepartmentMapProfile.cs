using AutoMapper;
using HRManage.Models.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.AuthorityManagement.Dto
{
   public class DepartmentMapProfile:Profile
    {
      public DepartmentMapProfile()
        {
            CreateMap<DepartmentDto, Department>();
            CreateMap<CreateUpdateDepartmentDto, Department>();
        }
    }
}
