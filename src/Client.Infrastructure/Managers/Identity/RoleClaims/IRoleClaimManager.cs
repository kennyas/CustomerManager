using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerManager.Application.Requests.Identity;
using CustomerManager.Application.Responses.Identity;
using CustomerManager.Shared.Wrapper;

namespace CustomerManager.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}