using System.ComponentModel.DataAnnotations;

namespace HandsOnCoding.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public ICollection<Batch>? Batches { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        [Required]
        public int CourseDuration { get; set; }
        public bool CourseStatus { get; set; }
    }
}
