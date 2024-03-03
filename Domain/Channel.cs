using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Channel
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }
}