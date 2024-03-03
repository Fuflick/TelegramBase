using System.ComponentModel.DataAnnotations;

namespace Domain;

public class UserChat
{
    [Key]
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? ChatId { get; set; }
}