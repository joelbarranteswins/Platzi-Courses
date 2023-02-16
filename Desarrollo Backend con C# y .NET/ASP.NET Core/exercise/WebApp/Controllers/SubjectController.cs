using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using WebApp.Models;

namespace WebApp.Controllers;

public class SubjectController : Controller
{
    public IActionResult Index()
    {
        var subject = new Subject
        {
            Name = "Matemáticas",
            UniqueId = Guid.NewGuid().ToString()
        };
        return View(subject);
    }

        public IActionResult MultiSubject()
    {
        var subjects = new List<Subject>()
        {
            new Subject
            {
                Name="Matemáticas",
                UniqueId= Guid.NewGuid().ToString()
            } ,
            new Subject
            {
                Name="Educación Física",
                UniqueId= Guid.NewGuid().ToString()
            },
            new Subject
            {
                Name="Castellano",
                UniqueId= Guid.NewGuid().ToString()
            },
            new Subject{Name="Ciencias Naturales",
                UniqueId= Guid.NewGuid().ToString()
            },
            new Subject
            {
            Name="Programación",
            UniqueId= Guid.NewGuid().ToString()
            }
        };

        ViewBag.ThingDynamic = "new variable";
        ViewBag.Date = DateTime.Now.ToString("d");

        return View("MultiSubject",subjects);
    }
}

