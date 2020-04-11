using CleanArchitectureTemplate.Application.Common.Interfaces;
using CleanArchitectureTemplate.Application.Notifications.Models;
using System.Threading.Tasks;

namespace CleanArchitectureTemplate.Infrastructure.Services
{
    public class MailService : IMailService
    {
        public Task SendMailAsync(MessageDto message)
        {
            throw new System.NotImplementedException();
        }
    }
}
