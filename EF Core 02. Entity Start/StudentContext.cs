using Microsoft.EntityFrameworkCore;

namespace EF_Core_02._Entity_Start;

internal class StudentContext: DbContext
{
    public DbSet<Student> Students { get; set; }

    public StudentContext()
    {
        //Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Students;Integrated Security=SSPI;");
    }
}
