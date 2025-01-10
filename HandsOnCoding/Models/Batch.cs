namespace HandsOnCoding.Models
{
    public class Batch
    {
        public int BatchID { get; set; }
        public string BatchName { get; set; }
        public DateTime StartFrom { get; set; }


        //Foreign Key
        public int CourseId { get; set; }
        public Course? Course { get; set; }
    }
}
