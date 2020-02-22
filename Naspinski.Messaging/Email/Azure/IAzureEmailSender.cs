using System.Threading.Tasks;

namespace Naspinski.Messaging.Email.Azure
{
    public interface IAzureEmailSender
    {
        Task<ResponseMessage> SendAsync(EmailMessage message);
    }
}
