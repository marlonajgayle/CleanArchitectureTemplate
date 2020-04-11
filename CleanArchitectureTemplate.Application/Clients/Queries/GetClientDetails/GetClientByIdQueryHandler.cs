using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureTemplate.Application.Clients.Queries.GetClientDetails
{
    public class GetClientByIdQueryHandler : IRequestHandler<GetClientByIdQuery, Unit>
    {
        public Task<Unit> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
