using Microsoft.EntityFrameworkCore;
using SmartStudentTracker.Models;

public class FakeDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    
    public FakeDbContext(DbContextOptions<FakeDbContext> options) : base(options) { }
}