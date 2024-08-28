using Microsoft.EntityFrameworkCore;
namespace EF_Core_02._DatabaseFirst;

internal class LibraryContext: DbContext
{
    public DbSet<Author> Authors {  get; set; }
    public DbSet<Lib> Libs {  get; set; }
    public LibraryContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=SSPI;");
    }
}
