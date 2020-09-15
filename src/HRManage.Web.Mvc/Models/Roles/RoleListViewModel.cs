using System.Collections.Generic;
using HRManage.Roles.Dto;

namespace HRManage.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
