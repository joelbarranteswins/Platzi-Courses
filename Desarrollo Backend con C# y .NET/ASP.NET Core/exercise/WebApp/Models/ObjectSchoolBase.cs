using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public abstract class ObjectSchoolBase
{
    [Key]
    public string UniqueId { get; set; }
    public string? Name { get; set; }

    public ObjectSchoolBase()
    {
        UniqueId = Guid.NewGuid().ToString();
    }

    public override string ToString()
    {
        return $"{Name},{UniqueId}";
    }
}
