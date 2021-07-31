using AutoMapper;
using CustomerManager.Infrastructure.Models.Audit;
using CustomerManager.Application.Responses.Audit;

namespace CustomerManager.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}