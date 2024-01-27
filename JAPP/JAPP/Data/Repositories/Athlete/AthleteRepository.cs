namespace JAPP.Data.Repositories.Athlete;

using Microsoft.EntityFrameworkCore;
using MinAPI.Database.Models;
using Tensorflow.Contexts;

public class AthleteRepository(ApplicationDbContext _context) : IAthleteRepository
{
    public async Task<IEnumerable<AthleteModel>> GetAthletes(bool? isActive)
    {
        return await _context.Athlete
        .Where(a => isActive == null || a.IsActive == isActive)
        .ToListAsync();
    }

    public async Task<AthleteModel?> GetAthleteByID(Guid id)
    {
        return await _context.Athlete.FindAsync(id);
    }

    public async Task InsertAthlete(AthleteModel athlete)
    {
        athlete.ID = new Guid();
        await _context.Athlete.AddAsync(athlete);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAthlete(AthleteModel athlete) {
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAthlete(Guid id)
    {
        if (await _context.Athlete.FindAsync(id) is AthleteModel athlete)
        {
            _context.Athlete.Remove(athlete);
        }
        await _context.SaveChangesAsync();

    }
}
