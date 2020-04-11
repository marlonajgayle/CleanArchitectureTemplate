using MediatR;

namespace CleanArchitectureTemplate.Application.Clients.Queries.GetClientDetails
{
    public class GetClientByIdQuery : IRequest<Unit>
    {
        public long ClientId { get; set; }

        public GetClientByIdQuery(long clientId)
        {
            ClientId = clientId;
        }
    }
}
