using InheritanceTPH_TPT_TPC.Models;

namespace InheritanceTPH_TPT_TPC;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(
                @"Data Source=(LocalDb)\MSSQLLocalDb;Database=Inheritance")
            .LogTo(Console.WriteLine, new[] { RelationalEventId.CommandExecuted }).EnableSensitiveDataLogging();


    public DbSet<Animal> Animals => Set<Animal>();
    public DbSet<Pet>Pets=> Set<Pet>();
    public DbSet<FarmAnimal> FarmAnimals => Set<FarmAnimal>();
    public DbSet<Dog> DbSet => Set<Dog>();
    public DbSet<Cat> Cats => Set<Cat>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>();
        modelBuilder.Entity<Pet>();
        modelBuilder.Entity<FarmAnimal>();
        modelBuilder.Entity<Dog>();
        modelBuilder.Entity<Cat>();

        base.OnModelCreating(modelBuilder);
    }
}
