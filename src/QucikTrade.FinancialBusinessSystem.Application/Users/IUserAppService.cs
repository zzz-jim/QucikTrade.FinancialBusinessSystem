using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using QucikTrade.FinancialBusinessSystem.Roles.Dto;
using QucikTrade.FinancialBusinessSystem.Users.Dto;

namespace QucikTrade.FinancialBusinessSystem.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
