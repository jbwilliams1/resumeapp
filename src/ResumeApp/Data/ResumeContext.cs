using ResumeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ResumeApp.Data
{
    public class ResumeContext : DbContext
    {
        public ResumeContext(DbContextOptions<ResumeContext> options) 
            : base(options)
        { }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}