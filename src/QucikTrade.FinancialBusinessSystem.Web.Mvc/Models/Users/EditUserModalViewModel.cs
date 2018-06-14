using System.Collections.Generic;
using System.Linq;
using QucikTrade.FinancialBusinessSystem.Roles.Dto;
using QucikTrade.FinancialBusinessSystem.Users.Dto;

namespace QucikTrade.FinancialBusinessSystem.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
