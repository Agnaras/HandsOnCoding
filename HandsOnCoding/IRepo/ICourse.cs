using HandsOnCoding.Models;

namespace HandsOnCoding.IRepo
{
    public interface ICourse
    {
        List<Course> GetCourses();
        Course GetCourseById(int id);
        bool AddCourse(Course user);
        bool UpdateCourse(int id, Course course);
        bool DeleteCourse(int id);

    }
}
