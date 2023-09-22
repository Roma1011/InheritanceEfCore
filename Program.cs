using InheritanceTPH_TPT_TPC;
using InheritanceTPH_TPT_TPC.Models;
using Microsoft.EntityFrameworkCore;

using (var context = new AppDbContext())
{
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();

    context.AddRange(
        new Cat
        {
            Name = "Alice"
            ,Species = "Felis catus"
            ,Colorful = true
        },
        new Cat
        {
            Name = "Tommy"
            ,
            Species = "Felis Tommius"
            ,
            Colorful = true
        },
        new Dog
        {
            Name = "Cerberus"
            ,
            Species = "Felis Cerberus"
            ,
            FavoriteToy = "Cat"
        }, 
        new FarmAnimal
        {
            Value=50.0m,
            Species = "Felis Dogus"
        });

    context.SaveChanges();
}

using (var context=new AppDbContext())
{
    var result1 = context.Animals.Where(a => a.Species.StartsWith("F")).ToList();
    var result2 = context.Animals.Where(a => a.Species.StartsWith("F")).ToList();
    var result3 = context.Animals.Where(a => a.Species.StartsWith("F")).ToList();
}

