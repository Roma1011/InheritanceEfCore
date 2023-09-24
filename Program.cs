using InheritanceTPH_TPT_TPC;
using InheritanceTPH_TPT_TPC.Models;
using Microsoft.EntityFrameworkCore;

using (var context = new AppDbContext())
{
    //context.Database.EnsureDeleted();
    //context.Database.EnsureCreated();

    var catDna = new DnaSeqvence { Bases = "MEWMEWMEW" };
    var dogDna = new DnaSeqvence { Bases = "WOFWOFWOF" };
    var SheepDna = new DnaSeqvence { Bases = "GAATAACAA" };
    context.AddRange(
        /*new Cat
        {
            Name = "Alice"
            , Species = "Felis catus"
            , Colorful = true
            , Dna = catDna
        },*/
        new Human
        {
            
        }
        new Cat
        {
            Name = "Alice"
            , Species = "Cibucius katus"
            , Colorful = true
            , Dna = catDna
        }
        /*new Cat
        {
            Name = "Tommy"
            , Species = "Felis Tommius"
            , Colorful = true
            , Dna = catDna
        },
        new Dog
        {
            Name = "Cerberus"
            , Species = "Felis Cerberus"
            , FavoriteToy = "Cat"
            , Dna = dogDna
        }, 
        new FarmAnimal
        {
            Value=50.0m
            , Species = "Felis Dogus"
            , Dna = SheepDna
        }*/);

    context.SaveChanges();
}

using (var context=new AppDbContext())
{
    var result1 = context.Animals.Where(a => a.Species.StartsWith("F")).ToList();
    var result2 = context.Pets.Where(a => a.Species.StartsWith("F")).ToList();
    var result3 = context.FarmAnimals.Where(a => a.Species.StartsWith("F")).ToList();
}

