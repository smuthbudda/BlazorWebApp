using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MinAPI.Database.Models
{
    public class Workout
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<Exercise>? Exercises { get; set; }
        public Guid AthleteID { get; set; } = default!;
        public virtual Athlete Athlete { get; set; } = default!;
    }
}
