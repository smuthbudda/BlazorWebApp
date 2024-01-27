using System.ComponentModel.DataAnnotations;

namespace JAPP.Data.DatabaseModels
{
    public class PointsModel
    {
        [Key]
        public int ID { get; set; }
        public int Points { get; set; }
        public string? Gender { get; set; }
        public string? Category { get; set; }
        public EventEnum Event { get; set; }
        public double Mark { get; set; }
        public TimeSpan MarkTime
        {
            get
            {
                return TimeSpan.FromSeconds(Mark);
            }
        }

        public enum EventEnum
        {
            [Display(Name = "10 Miles")]
            Miles10,

            [Display(Name = "10,000m")]
            Meters10000,

            [Display(Name = "10,000mW")]
            Meters10000W,

            [Display(Name = "1000m")]
            Meters1000,

            [Display(Name = "100km")]
            Kilometers100,

            [Display(Name = "100m")]
            Meters100,

            [Display(Name = "100mH")]
            Meters100H,

            [Display(Name = "10km")]
            Kilometers10,

            [Display(Name = "10kmW")]
            Kilometers10W,

            [Display(Name = "110mH")]
            Meters110H,

            [Display(Name = "15,000mW")]
            Meters15000W,

            [Display(Name = "1500m")]
            Meters1500,

            [Display(Name = "15km")]
            Kilometers15,

            [Display(Name = "15kmW")]
            Kilometers15W,

            [Display(Name = "2 Miles")]
            Miles2,

            [Display(Name = "20,000mW")]
            Meters20000W,

            [Display(Name = "2000m")]
            Meters2000,

            [Display(Name = "2000mSC")]
            Meters2000SC,

            [Display(Name = "200m")]
            Meters200,

            [Display(Name = "20km")]
            Kilometers20,

            [Display(Name = "20kmW")]
            Kilometers20W,

            [Display(Name = "25km")]
            Kilometers25,

            [Display(Name = "30,000mW")]
            Meters30000W,

            [Display(Name = "3000m")]
            Meters3000,

            [Display(Name = "3000mSC")]
            Meters3000SC,

            [Display(Name = "3000mW")]
            Meters3000W,

            [Display(Name = "300m")]
            Meters300,

            [Display(Name = "30km")]
            Kilometers30,

            [Display(Name = "30kmW")]
            Kilometers30W,

            [Display(Name = "35,000mW")]
            Meters35000W,

            [Display(Name = "35kmW")]
            Kilometers35W,

            [Display(Name = "3kmW")]
            Kilometers3W,

            [Display(Name = "400m")]
            Meters400,

            [Display(Name = "400mH")]
            Meters400H,

            [Display(Name = "4x100m")]
            Meters4x100,

            [Display(Name = "4x200m")]
            Meters4x200,

            [Display(Name = "4x400m")]
            Meters4x400,

            [Display(Name = "50,000mW")]
            Meters50000W,

            [Display(Name = "5000m")]
            Meters5000,

            [Display(Name = "5000mW")]
            Meters5000W,

            [Display(Name = "500m")]
            Meters500,

            [Display(Name = "50kmW")]
            Kilometers50W,

            [Display(Name = "5km")]
            Kilometers5,

            [Display(Name = "5kmW")]
            Kilometers5W,

            [Display(Name = "600m")]
            Meters600,

            [Display(Name = "800m")]
            Meters800,

            [Display(Name = "DT")]
            DiscusThrow,

            [Display(Name = "Heptathlon")]
            Heptathlon,

            [Display(Name = "Decathlon")]
            Decathlon,

            [Display(Name = "HJ")]
            HighJump,

            [Display(Name = "HM")]
            HalfMarathon,

            [Display(Name = "HT")]
            HammerThrow,

            [Display(Name = "JT")]
            JavelinThrow,

            [Display(Name = "LJ")]
            LongJump,

            [Display(Name = "Marathon")]
            Marathon,

            [Display(Name = "Mile")]
            Mile,

            [Display(Name = "PV")]
            PoleVault,

            [Display(Name = "SP")]
            ShotPut,

            [Display(Name = "TJ")]
            TripleJump,

            [Display(Name = "50m")]
            Meters50,

            [Display(Name = "55m")]
            Meters55,

            [Display(Name = "60m")]
            Meters60,

            [Display(Name = "50mH")]
            Meters50H,

            [Display(Name = "55mH")]
            Meters55H,

            [Display(Name = "60mH")]
            Meters60H,

            [Display(Name = "Pentathlon")]
            Pentathlon,

            Undefined
        }
    }
}
