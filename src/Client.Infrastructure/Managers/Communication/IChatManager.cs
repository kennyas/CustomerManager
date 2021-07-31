using CustomerManager.Application.Models.Chat;
using CustomerManager.Application.Responses.Identity;
using CustomerManager.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerManager.Application.Interfaces.Chat;

namespace CustomerManager.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}