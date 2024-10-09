using Microsoft.AspNetCore.Identity;

namespace MZEstateAgents.Areas.Data
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
