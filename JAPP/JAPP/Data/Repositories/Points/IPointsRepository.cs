using JAPP.Data.DatabaseModels;

namespace JAPP.Data.Repositories.Points
{
    public interface IPointsRepository
    {
        Task BulkInsert(IList<PointsModel> pointsModels);
    }
}
