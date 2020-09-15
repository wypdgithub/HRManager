using Abp.Application.Services.Dto;
using System;
using System.ComponentModel.DataAnnotations;

namespace HRManage.AuthorityManagement.Dto
{
    public class UserInfoDto : EntityDto<Guid>
    {
        public string Login_Name { get; set; }
        public string PassWord { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
    }
}
