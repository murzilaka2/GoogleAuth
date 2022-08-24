using Microsoft.AspNetCore.Identity;

namespace GoogleAuth.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
