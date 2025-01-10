namespace HandsOnCoding.ViewModal
{
    public class CourseBatch
    {
        public int Id { get; set; }
        public int CourseID { get; set; }
        public int BatchID { get; set; }
        public string CourseName { get; set; }
        public string BatchName { get; set; }

        public DateTime BatchStartFrom { get; set; }

        public DateTime CourseEndOn { get; set; }
        public int CourseDuration { get; set; }
    }

    public class CourseName
    {
        public int Id { get; set; }
        public string CourseToBeAllocated { get; set; }
    }
}
