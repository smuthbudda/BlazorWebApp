using JAPP.Data.DatabaseModels;

namespace JAPP.Data.Repositories.Points
{
    public class PointsRepository(ApplicationDbContext _context) : IPointsRepository
    {
        public async Task BulkInsert(IList<PointsModel> points)
        {
            await _context.Points.AddRangeAsync(points);
            await _context.SaveChangesAsync();
        }

    }
}
