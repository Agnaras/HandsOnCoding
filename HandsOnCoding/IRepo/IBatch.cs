using HandsOnCoding.Models;
using HandsOnCoding.ViewModal;

namespace HandsOnCoding.IRepo
{
    public interface IBatch
    {
        List<Batch> GetBatches();
        Batch GetBatchById(int id);
        bool AddBatch(Batch batch);
        bool UpdateBatch(int id, Batch batch);
        bool DeleteBatch(int id);
        List<CourseBatch> GetCourseBatchDetails();
        List<CourseName> GetAllCourses();
    }
}
