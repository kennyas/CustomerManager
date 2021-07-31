using AutoMapper;
using CustomerManager.Infrastructure.Models.Identity;
using CustomerManager.Application.Responses.Identity;

namespace CustomerManager.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, ApplicationRole>().ReverseMap();
        }
    }
}