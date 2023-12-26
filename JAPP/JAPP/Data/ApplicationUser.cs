using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JAPP.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DateOnly BirthDate { get; set; }
    }

}
