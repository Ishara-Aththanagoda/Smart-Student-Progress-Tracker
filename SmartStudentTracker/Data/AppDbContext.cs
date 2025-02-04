using Microsoft.EntityFrameworkCore;
using SmartStudentTracker.Models;

namespace SmartStudentTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Progress> ProgressRecords { get; set; }
    }
}
