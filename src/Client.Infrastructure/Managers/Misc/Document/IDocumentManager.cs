using CustomerManager.Application.Features.Documents.Commands.AddEdit;
using CustomerManager.Application.Features.Documents.Queries.GetAll;
using CustomerManager.Application.Requests.Documents;
using CustomerManager.Shared.Wrapper;
using System.Threading.Tasks;
using CustomerManager.Application.Features.Documents.Queries.GetById;

namespace CustomerManager.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}