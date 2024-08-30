using Microsoft.EntityFrameworkCore;

namespace EF_Core_04._Code_First._One_To_One;

internal class StudentContext: DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentCard> StudentCards { get; set; }

    public StudentContext()
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OneToOne;Integrated Security=SSPI;");
    }
}
