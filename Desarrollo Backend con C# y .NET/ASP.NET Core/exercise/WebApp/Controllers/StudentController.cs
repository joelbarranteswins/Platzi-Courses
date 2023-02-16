using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using WebApp.Models;
using System.Linq;

namespace WebApp.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        var subject = new Student
        {
            Name = "Juan perez",
            UniqueId = Guid.NewGuid().ToString()
        };
        return View(subject);
    }

    public IActionResult MultiStudent()
    {
        var students = Student.GenerateStudentRandom();
        return View("MultiStudent",students);
    }

    
}

