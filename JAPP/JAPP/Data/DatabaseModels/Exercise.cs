using MinAPI.Database.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace MinAPI.Database.Models
{
    public class Exercise
    {
        [Key]
        public int ID { get; set; }
        public string? Intensity { get; set; }
        public string? Rest { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public Guid AthleteID { get; set; } = default!;
        public virtual AthleteModel Athlete { get; set; } = default!;
        public virtual required ICollection<Distance> Distances { get; set; } 
    }

    
}
