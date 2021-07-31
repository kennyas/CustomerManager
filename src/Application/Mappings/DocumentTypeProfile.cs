using AutoMapper;
using CustomerManager.Application.Features.DocumentTypes.Commands.AddEdit;
using CustomerManager.Application.Features.DocumentTypes.Queries.GetAll;
using CustomerManager.Application.Features.DocumentTypes.Queries.GetById;
using CustomerManager.Domain.Entities.Misc;

namespace CustomerManager.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}