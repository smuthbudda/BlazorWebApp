using JAPP.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MinAPI.Database.Models
{

    public class AthleteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public DateTime? BirthDate { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }

        public virtual ApplicationUser? User { get; set; }
    }
}
