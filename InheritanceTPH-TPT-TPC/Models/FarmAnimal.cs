using System.ComponentModel.DataAnnotations.Schema;

namespace InheritanceTPH_TPT_TPC.Models;

public class FarmAnimal:Animal
{
    [Column(TypeName = "decimal(5,2)")]
    public decimal Value { get; set; }
}