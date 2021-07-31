using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerManager.Application.Interfaces.Common;
using CustomerManager.Application.Requests.Identity;
using CustomerManager.Application.Responses.Identity;
using CustomerManager.Shared.Wrapper;

namespace CustomerManager.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}