using CleanArchitectureTemplate.Application.Notifications.Models;
using System.Threading.Tasks;

namespace CleanArchitectureTemplate.Application.Common.Interfaces
{
    public interface IMailService
    {
        Task SendMailAsync(MessageDto message);
    }
}
