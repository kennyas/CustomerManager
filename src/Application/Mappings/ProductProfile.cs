using AutoMapper;
using CustomerManager.Application.Features.Products.Commands.AddEdit;
using CustomerManager.Domain.Entities.Catalog;

namespace CustomerManager.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}