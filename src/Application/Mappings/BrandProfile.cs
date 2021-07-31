using AutoMapper;
using CustomerManager.Application.Features.Brands.Commands.AddEdit;
using CustomerManager.Application.Features.Brands.Queries.GetAll;
using CustomerManager.Application.Features.Brands.Queries.GetById;
using CustomerManager.Domain.Entities.Catalog;

namespace CustomerManager.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}