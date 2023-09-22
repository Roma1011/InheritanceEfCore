namespace InheritanceTPH_TPT_TPC.Models;

public abstract class Animal
{
    public int Id { get; set; }
    public string Species { get; set; } = null!;
    public int? DnaId { get; set; }
    public DnaSeqvence?Dna { get; set; }
}