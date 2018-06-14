using System.Collections.Generic;
using QucikTrade.FinancialBusinessSystem.Roles.Dto;
using QucikTrade.FinancialBusinessSystem.Users.Dto;

namespace QucikTrade.FinancialBusinessSystem.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
