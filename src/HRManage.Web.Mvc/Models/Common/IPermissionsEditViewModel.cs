using System.Collections.Generic;
using HRManage.Roles.Dto;

namespace HRManage.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}