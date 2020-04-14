using CleanArchitectureTemplate.Application.Common.Interfaces;
using CleanArchitectureTemplate.Domain.Entities;
using CleanArchitectureTemplate.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureTemplate.Infrastructure.Persistence
{
    public class InvestEdgeDbContext : IdentityDbContext<ApplicationUser>, IInvestEdgeDbContext
    {
        public InvestEdgeDbContext(DbContextOptions<InvestEdgeDbContext> options)
              : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
