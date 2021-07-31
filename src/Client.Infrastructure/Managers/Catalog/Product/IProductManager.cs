using CustomerManager.Application.Features.Products.Commands.AddEdit;
using CustomerManager.Application.Features.Products.Queries.GetAllPaged;
using CustomerManager.Application.Requests.Catalog;
using CustomerManager.Shared.Wrapper;
using System.Threading.Tasks;

namespace CustomerManager.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}