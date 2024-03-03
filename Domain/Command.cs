using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Command
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }
}