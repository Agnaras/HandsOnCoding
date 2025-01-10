using HandsOnCoding.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using HandsOnCoding.ViewModal;

namespace HandsOnCoding.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seeding data > want to initialze data
            modelBuilder.Entity<Course>()
                 .HasData(
                    new Course()
                    {
                        CourseId = 1,
                        CourseName = "java",
                        CourseDescription = "Intermediate java to advance",
                        CourseDuration = 40,
                        CourseStatus = true
                    },
                    new Course()
                    {
                        CourseId = 2,
                        CourseName = "dotNet",
                        CourseDescription = "Intermediate dotNet to advance",
                        CourseDuration = 40,
                        CourseStatus = true
                    },
                    new Course()
                    {
                        CourseId = 3,
                        CourseName = "Python",
                        CourseDescription = "Intermediate Python to advance",
                        CourseDuration = 40,
                        CourseStatus = true
                    },
                    new Course()
                    {
                        CourseId = 4,
                        CourseName = "SharePoint",
                        CourseDescription = "Intermediate SharePoint to advance",
                        CourseDuration = 40,
                        CourseStatus = true
                    }
                );
            modelBuilder.Entity<Batch>()
               .HasData(
                 new Batch()
                 {
                     BatchID = 1,
                     BatchName = "OIL",
                     CourseId = 1,
                     StartFrom = new DateTime(2024, 08, 18),

                 },
                 new Batch()
                 {
                     BatchID = 2,
                     BatchName = "OIL",
                     CourseId = 1,
                     StartFrom =new DateTime(2024, 09, 12),
                     
                 },
                 new Batch()
                 {
                     BatchID = 3,
                     BatchName = "OIL",
                     CourseId = 2,
                     StartFrom = new DateTime(2024, 12, 18),

                 },
                 new Batch()
                 {
                     BatchID = 4,
                     BatchName = "OIL",
                     CourseId = 3,
                     StartFrom = new DateTime(2025, 01, 06),

                 }
               );

        }
        public DbSet<HandsOnCoding.ViewModal.CourseBatch> CourseBatch { get; set; } = default!;

        


    }
}
