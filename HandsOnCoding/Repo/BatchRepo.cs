using HandsOnCoding.Context;
using HandsOnCoding.IRepo;
using HandsOnCoding.Models;
using HandsOnCoding.ViewModal;

namespace HandsOnCoding.Repo
{
    public class BatchRepo : IBatch
    {
        private readonly AppDbContext _context;
        public BatchRepo(AppDbContext context)
        {
            _context = context;
        }
        public bool AddBatch(Batch batch)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBatch(int id)
        {
            throw new NotImplementedException();
        }

        public List<CourseName> GetAllCourses()
        {
            List<CourseName> course = new List<CourseName>();
            course = (from x in _context.Courses
                        where x.CourseStatus == true
                        select new CourseName()
                        {
                            Id = x.CourseId,
                            CourseToBeAllocated = x.CourseName
                        }).ToList();
            return course;
        }

        public Batch GetBatchById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Batch> GetBatches()
        {
            throw new NotImplementedException();
        }

        public List<CourseBatch> GetCourseBatchDetails()
        {
            List<CourseBatch> courseBatches = new List<CourseBatch>();
            courseBatches = (from x in _context.Courses
                             join y in _context.Batches
                             on x.CourseId equals y.BatchID
                             select new CourseBatch()
                             {
                                 CourseID = x.CourseId,
                                 CourseName = x.CourseName,
                                 BatchID = y.BatchID,
                                 BatchName = y.BatchName,
                                 BatchStartFrom = y.StartFrom,
                                 CourseEndOn = y.StartFrom.AddDays(x.CourseDuration),
                                 CourseDuration = x.CourseDuration
                             }).ToList();

            return courseBatches;

        }

        public bool UpdateBatch(int id, Batch batch)
        {
            throw new NotImplementedException();
        }

       
    }
}
