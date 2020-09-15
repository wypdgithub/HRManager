using Abp.Application.Services.Dto;
using System;
using System.ComponentModel.DataAnnotations;

namespace HRManage.AuthorityManagement.Dto
{
    public class UserInfoDto : EntityDto<Guid>
    {
        [StringLength(64)]
        public string Login_Name { get; set; }
        [StringLength(64)]
        public string PassWord { get; set; }
        [StringLength(64)]
        public string UserName { get; set; }
        [StringLength(64)]
        public string Mobile { get; set; }
        [StringLength(64)]
        public string Email { get; set; }
        [StringLength(64)]
        public string State { get; set; }
    }
}
