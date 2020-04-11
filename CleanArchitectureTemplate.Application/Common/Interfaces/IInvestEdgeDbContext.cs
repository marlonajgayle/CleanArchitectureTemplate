using CleanArchitectureTemplate.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureTemplate.Application.Common.Interfaces
{
    public interface IInvestEdgeDbContext
    {
        public DbSet<Client> Clients { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
