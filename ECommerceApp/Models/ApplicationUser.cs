using Microsoft.AspNetCore.Identity;

namespace ECommerceApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
