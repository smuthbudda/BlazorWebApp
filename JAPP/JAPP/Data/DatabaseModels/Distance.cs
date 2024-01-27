using System.ComponentModel.DataAnnotations;

namespace MinAPI.Database.Models
{
    public class Distance()
    {
        [Key]
        public int ID { get; set; }
        public int DistanceRan { get; set; }
        public string? Name { get; set; }
        public virtual Exercise Exercise { get; set; }
        public int ExerciseID { get; set; }
    }
}
