﻿namespace App.Models;

public sealed class User
{
    public int? Id { get; set; }
    public string? Name { get; set;  }
    public string? Surname { get; set; }
    public string? Email { get; set;  }
}