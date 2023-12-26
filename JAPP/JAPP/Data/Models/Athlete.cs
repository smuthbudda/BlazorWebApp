using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MinAPI.Database.Models
{

    public class Athlete
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        public string? PasswordSalt { get; set; }
        
        [Required]
        public DateOnly BirthDate { get; set; }
    }
}
