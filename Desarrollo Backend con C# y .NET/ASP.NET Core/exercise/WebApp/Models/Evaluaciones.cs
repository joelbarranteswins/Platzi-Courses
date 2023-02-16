using System;

namespace WebApp.Models;

public class Evaluations
{
    public string? UniqueId { get; private set; }
    public string? Name { get; set; }

    public Student? Student { get; set; }
    public Subject? Subject  { get; set; }

    public float Grade { get; set; }

    public Evaluations() => UniqueId = Guid.NewGuid().ToString();
}
