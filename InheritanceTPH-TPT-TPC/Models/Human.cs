using System.Collections.ObjectModel;

namespace InheritanceTPH_TPT_TPC.Models;

public class Human
{
    public int Id { get; set; }
    public int? FavoriteAnimalId { get; set; }
    public Animal? FavoriteAnimal { get; set; }
}