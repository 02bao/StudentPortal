using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models.Entity;

namespace StudentPortal.Web.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Student> Students { get; set; }

    public static string configsql = "Host=localhost:5432;Database=StudentPortal;Username=postgres;Password=postgres";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql(configsql);
    }
}
