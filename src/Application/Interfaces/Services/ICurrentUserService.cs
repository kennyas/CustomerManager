using CustomerManager.Application.Interfaces.Common;

namespace CustomerManager.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}