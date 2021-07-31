using CustomerManager.Shared.Wrapper;
using System.Threading.Tasks;
using CustomerManager.Application.Features.Dashboards.Queries.GetData;

namespace CustomerManager.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}