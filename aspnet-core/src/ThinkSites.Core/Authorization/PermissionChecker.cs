using Abp.Authorization;
using ThinkSites.Authorization.Roles;
using ThinkSites.Authorization.Users;

namespace ThinkSites.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
