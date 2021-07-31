using CustomerManager.Application.Interfaces.Common;
using CustomerManager.Application.Requests.Identity;
using CustomerManager.Application.Responses.Identity;
using CustomerManager.Shared.Wrapper;
using System.Threading.Tasks;

namespace CustomerManager.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}