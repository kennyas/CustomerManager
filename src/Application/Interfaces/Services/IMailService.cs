using CustomerManager.Application.Requests.Mail;
using System.Threading.Tasks;

namespace CustomerManager.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}