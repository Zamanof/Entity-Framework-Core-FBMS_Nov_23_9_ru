using Microsoft.EntityFrameworkCore;

namespace EF_Core_07.__Loadings._Eager_loading;

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
       optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EagerLoading; Integrated Security=SSPI");
    }

}
