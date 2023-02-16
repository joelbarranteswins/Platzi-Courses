using System;

namespace WebApp.Models;

public class Evaluation : ObjectSchoolBase
{
    public Student? Student { get; set; }
    public Subject? Subject  { get; set; }
    public float Nota { get; set; }

    public override string ToString()
    {
        return $"{Nota}, {Student?.Name}, {Subject?.Name}";
    }
}
