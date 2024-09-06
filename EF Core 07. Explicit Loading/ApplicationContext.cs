using Microsoft.EntityFrameworkCore;

namespace EF_Core_07._Explicit_Loading;

internal class ApplicationContext: DbContext
{
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ExplicitLoading; Integrated Security=SSPI");
    }
}
