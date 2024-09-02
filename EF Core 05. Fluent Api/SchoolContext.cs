﻿using Microsoft.EntityFrameworkCore;
namespace EF_Core_05._Fluent_Api;
internal class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Departament> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }

    public SchoolContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=AcademyWithFluentAPI; Integrated Security=SSPI");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Group
        modelBuilder
            .Entity<Group>()
            .Property(x => x.GroupName)
            .IsRequired()
            .HasMaxLength(10);
        
        modelBuilder
            .Entity<Group>()
            .HasIndex(x => x.GroupName)
            .IsUnique();
        
        modelBuilder
            .Entity<Group>()
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();

        modelBuilder
            .Entity<Group>()
            .ToTable(x => x.HasCheckConstraint("CK_GroupRating",
            "GroupRating>=0 AND GroupRating<=12"));

        modelBuilder
            .Entity<Group>()
            .ToTable(x => x.HasCheckConstraint("CK_CourseYear",
            "CourseYear>=1 AND CourseYear<=4"));

        // Teacher
        modelBuilder
            .Entity<Teacher>()
            .Property(x=>x.TeacherId)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();

        modelBuilder
            .Entity<Teacher>()
            .Property (x=>x.FirstName)
            .IsRequired()
            .HasMaxLength(30);

        modelBuilder
            .Entity<Teacher>()
            .Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder
            .Entity<Teacher>()
            .HasIndex (x => x.Email)
            .IsUnique();

        modelBuilder
            .Entity <Teacher>()
            .Property(x=>x.Email)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(50);

        // Student
        modelBuilder
            .Entity<Student>()
            .HasOne(s => s.Group)
            .WithMany(g => g.Students)
            .HasForeignKey(s => s.GroupId)
            .OnDelete(DeleteBehavior.NoAction)
            .HasConstraintName("FK_Groups");

        modelBuilder
            .Entity<Student>()
            .Property(x=>x.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder
            .Entity<Student>()
            .Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder
            .Entity<Student>()
            .Property(x => x.GroupId)
            .HasColumnName("Id_Group");
    }
}
