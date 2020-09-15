using Abp.Authorization;
using HRManage.Authorization.Roles;
using HRManage.Authorization.Users;

namespace HRManage.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
