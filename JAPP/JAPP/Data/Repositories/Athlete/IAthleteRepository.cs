using MinAPI.Database.Models;

namespace JAPP.Data.Repositories.Athlete
{
    public interface IAthleteRepository
    {
        Task<IEnumerable<AthleteModel>> GetAthletes(bool? isActive);
        Task<AthleteModel?> GetAthleteByID(Guid id);
        Task InsertAthlete(AthleteModel athlete);
        Task UpdateAthlete(AthleteModel athlete);
        Task DeleteAthlete(Guid id);


    }
}