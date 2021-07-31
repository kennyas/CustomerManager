using AutoMapper;
using CustomerManager.Application.Features.Documents.Commands.AddEdit;
using CustomerManager.Application.Features.Documents.Queries.GetById;
using CustomerManager.Domain.Entities.Misc;

namespace CustomerManager.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}