using LTM.School.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LTM.School.EntityFramework {
    public class SchoolDbContext : DbContext {
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            //modelBuilder.Entity<Course>().Property(course => course.Id).ValueGeneratedNever();

            //modelBuilder.Entity<Enrollment>()
            //    .HasOne(enrollment => enrollment.Student)
            //    .WithMany(student => student.Enrollments)
            //    .HasForeignKey(enrollment => enrollment.StudentId);

            //modelBuilder.Entity<Enrollment>()
            //    .HasOne(enrollment => enrollment.Course)
            //    .WithMany(course => course.Enrollments);
        }

        public SchoolDbContext (DbContextOptions<SchoolDbContext> options) : base(options) {
        }
    }
}
