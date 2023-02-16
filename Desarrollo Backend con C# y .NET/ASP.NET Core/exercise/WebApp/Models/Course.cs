using System;
using System.Collections.Generic;


namespace WebApp.Models;

public class Course : ObjectSchoolBase
{
    public TypeSchedule Schedule { get; set; }
    public List<Subject>? Subjects{ get; set; }
    public List<Student>? Students{ get; set; }
    public string? Direction { get; set; } 
}
