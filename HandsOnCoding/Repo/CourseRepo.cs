using HandsOnCoding.Context;
using HandsOnCoding.IRepo;
using HandsOnCoding.Models;

namespace HandsOnCoding.Repo
{
    public class CourseRepo : ICourse
    {
        private readonly AppDbContext _context;
        public CourseRepo(AppDbContext context)
        {
            _context = context;
        }

        public bool AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteCourse(int id)
        {
            var course = GetCourseById(id);
            course.CourseStatus = false;
            return true;
        }

        public Course GetCourseById(int id)
        {
            var course = _context.Courses.FirstOrDefault(x => x.CourseId == id && x.CourseStatus == true);
            return course;
        }

        public List<Course> GetCourses()
        {
            return _context.Courses.Where(x => x.CourseStatus == true).ToList();
        }

        public bool UpdateCourse(int id, Course course)
        {
            var obj = GetCourseById(id);
            obj.CourseName = course.CourseName;
            obj.CourseDuration = course.CourseDuration;
            obj.CourseStatus = course.CourseStatus;
            obj.CourseDescription = course.CourseDescription;
            _context.SaveChanges();
            return true;
        }
    }
}
