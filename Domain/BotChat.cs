﻿using System.ComponentModel.DataAnnotations;

namespace Domain;

public class BotChat
{
    [Key]
    public int Id { get; set; }

    public int? BotId { get; set; }

    public int? ChatId { get; set; }
}