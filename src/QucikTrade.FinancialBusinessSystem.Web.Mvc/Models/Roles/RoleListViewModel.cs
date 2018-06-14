using System.Collections.Generic;
using QucikTrade.FinancialBusinessSystem.Roles.Dto;

namespace QucikTrade.FinancialBusinessSystem.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
