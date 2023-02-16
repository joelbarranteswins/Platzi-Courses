using System;
using System.Collections.Generic;

namespace WebApp.Models;

public class Student: ObjectSchoolBase
{
    public List<Evaluation> Evaluaciones { get; set; } = new List<Evaluation>();

    public static List<Student> GenerateStudentRandom()
    {
        string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
        string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
        string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

        var listStudent = from n1 in nombre1
                           from n2 in nombre2
                           from a1 in apellido1
                           select new Student
                           {
                               Name = $"{n1} {n2} {a1}",
                               UniqueId = Guid.NewGuid().ToString()
                           };

        return listStudent.OrderBy((al) => al.UniqueId).ToList();
    }


}
