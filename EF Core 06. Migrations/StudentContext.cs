using Microsoft.EntityFrameworkCore;

namespace EF_Core_06._Migrations;

internal class StudentContext: DbContext
{
    public DbSet<Student> Students { get; set; }

    public StudentContext()
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Migration; Integrated Security=SSPI");
    }

}
