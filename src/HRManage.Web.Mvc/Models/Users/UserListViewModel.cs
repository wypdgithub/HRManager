using System.Collections.Generic;
using HRManage.Roles.Dto;

namespace HRManage.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
