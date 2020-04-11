using CleanArchitectureTemplate.Application.Common.Interfaces;
using CleanArchitectureTemplate.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureTemplate.Application.Clients.Commands.CreateClient
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, int>
    {
        private readonly IInvestEdgeDbContext dbContext;

        public CreateClientCommandHandler(IInvestEdgeDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var entity = new Client()
            {
                FirstName = request.FirstName,
                MiddleIntial = request.MiddleIntial,
                LastName = request.LastName
            };

            dbContext.Clients.Add(entity);

            await dbContext.SaveChangesAsync(cancellationToken);

            return await dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
