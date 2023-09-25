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
    public DbSet<Dog> Dogs => Set<Dog>();
    public DbSet<Cat> Cats => Set<Cat>();
    public DbSet<Human> Humans => Set<Human>();
    public DbSet<DnaSeqvence> DnaSeqvences => Set<DnaSeqvence>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /*modelBuilder.Entity<Animal>().ToTable("Animals").UseTptMappingStrategy();
        modelBuilder.Entity<Pet>();
        modelBuilder.Entity<FarmAnimal>();
        modelBuilder.Entity<Dog>();
        modelBuilder.Entity<Cat>();
        modelBuilder.Entity<Human>();
        modelBuilder.Entity<DnaSeqvence>();*/

        modelBuilder.HasSequence<int>("AnimalIds");
        modelBuilder.Entity<Animal>().UseTpcMappingStrategy().Property(e => e.Id)
            .HasDefaultValueSql("NEXT VALUE FOR [AnimalIds]");
        
        modelBuilder.Entity<Animal>().UseTpcMappingStrategy();
        modelBuilder.Entity<Cat>().ToTable("Cats");
        modelBuilder.Entity<Dog>().ToTable("Dogs");
        modelBuilder.Entity<FarmAnimal>().ToTable("FarmAnimals");
        
        base.OnModelCreating(modelBuilder);
    }
}
