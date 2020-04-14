using MediatR;

namespace CleanArchitectureTemplate.Application.Clients.Commands.CreateClient
{
    public class CreateClientCommand : IRequest<int>
    {
        public long ClientId { get; set; }
        public string FirstName { get; set; }
        public string MiddleIntial { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public CreateClientCommand(ClientViewModel viewModel)
        {
            ClientId = viewModel.ClientId;
            FirstName = viewModel.FirstName;
            MiddleIntial = viewModel.MiddleIntial;
            LastName = viewModel.LastName;
            Email = viewModel.Email;
        }

    }
}
