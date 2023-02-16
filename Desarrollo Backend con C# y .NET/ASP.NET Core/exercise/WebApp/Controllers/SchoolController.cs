using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using System.Linq;

namespace WebApp.Controllers;

public class SchoolController : Controller
{

    public SchoolContext _context;
    public SchoolController(SchoolContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var school = new School()
        {
            UniqueId = Guid.NewGuid().ToString(),
            Name = "Joel School",
            YearFundation = DateTime.Parse("20-04-2025").ToString("dd-MM-yyyy"),
            Country = "Perú",
            City = "Lima",
            TypeSchool = TypeSchool.Secondary,
            Address = "Av. Chorrillos, 435 lincold k"
        };

        ViewBag.ThingDynamic = "new variable";

        var schools = _context.schools?.First();

        return View(schools);
    }
}

