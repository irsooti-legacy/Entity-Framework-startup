using Microsoft.EntityFrameworkCore;

namespace EfScaffoldingProject.Entities
{
    public class SchoolContext : DbContext
    {
        // public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        // {
        // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseMySql("server=192.168.42.128;userid=root;pwd=d0808!;port=3306;database=School");
            }
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}