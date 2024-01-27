using JAPP.Data.DatabaseModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MinAPI.Database.Models;

namespace JAPP.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public required DbSet<AthleteModel> Athlete { get; set; }
    public required DbSet<Exercise> Exercise { get; set; }
    public required DbSet<Workout> Workout { get; set; }
    public required DbSet<Distance> Distance { get; set; }
    public required DbSet<PointsModel> Points { get; set; }
    //jhgjkhg
}
