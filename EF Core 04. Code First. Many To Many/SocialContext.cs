using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace EF_Core_04._Code_First._Many_To_Many;

internal class SocialContext : DbContext
{
    public DbSet<SocialNetwork> SocialNetworks { get; set; }
    public DbSet<User> Users { get; set; }
    public SocialContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ManyToMany;Integrated Security=SSPI;");
    }

}
