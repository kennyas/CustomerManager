using AutoMapper;
using CustomerManager.Application.Interfaces.Chat;
using CustomerManager.Application.Models.Chat;
using CustomerManager.Infrastructure.Models.Identity;

namespace CustomerManager.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<ApplicationUser>>().ReverseMap();
        }
    }
}