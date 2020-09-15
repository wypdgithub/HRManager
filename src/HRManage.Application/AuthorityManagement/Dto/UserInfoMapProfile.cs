using AutoMapper;
using HRManage.Models.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.AuthorityManagement.Dto
{
   public class UserInfoMapProfile:Profile
    {
        public UserInfoMapProfile() {
            CreateMap<UserInfoDto, UserInfo>();
            CreateMap<CreateUpdateUserInfoDto, UserInfo>();
        }

    }
}
