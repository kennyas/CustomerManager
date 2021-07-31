using CustomerManager.Application.Responses.Identity;
using CustomerManager.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerManager.Application.Interfaces.Chat;
using CustomerManager.Application.Models.Chat;

namespace CustomerManager.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}