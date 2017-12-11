using LTM.School.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LTM.School.EntityFramework {
    public class SchoolDbContext : DbContext {
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
        }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) {
        }
    }
}
