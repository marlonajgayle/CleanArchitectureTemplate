using Microsoft.AspNetCore.Identity;

namespace CleanArchitectureTemplate.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long ClientId { get; set; }
    }
}
