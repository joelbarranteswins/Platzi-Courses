using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models;

public class SchoolContext : DbContext
{
    public DbSet<School>? schools { get; set; }
    public DbSet<Subject>? subjects { get; set; }
    public DbSet<Student>? students { get; set; }
    public DbSet<Course>? courses { get; set; }
    public DbSet<Evaluation>? evaluations { get; set; }
    
    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var schoolsInit = new List<School>(){
            new School()
                {
                    UniqueId = Guid.NewGuid().ToString(),
                    Name = "Joel School",
                    YearFundation = DateTime.Parse("20-04-2025").ToString("dd-MM-yyyy"),
                    Country = "Perú",
                    City = "Lima",
                    TypeSchool = TypeSchool.Secondary,
                    Address = "Av. Chorrillos, 435 lincold k"
                }
            };

        modelBuilder.Entity<School>().HasData(schoolsInit);
        //(
        //    school =>
        //    {
        //        //school.ToTable("Escuela");
        //        school.HasKey(s => s.UniqueId);
        //        school.Property(s => s.Name).HasMaxLength(100);
        //        school.HasData(schoolsInit);
        //    }
        //);


        List<Subject> subjectsInit = new List<Subject>()
        {
            new Subject() { UniqueId = Guid.NewGuid().ToString(), Name = "Matemáticas" },
            new Subject() { UniqueId = Guid.NewGuid().ToString(), Name = "Lenguaje" },
            new Subject() { UniqueId = Guid.NewGuid().ToString(), Name = "Ciencias" },
            new Subject() { UniqueId = Guid.NewGuid().ToString(), Name = "Historia" },
            new Subject() { UniqueId = Guid.NewGuid().ToString(), Name = "Geografía" },
            new Subject() { UniqueId = Guid.NewGuid().ToString(), Name = "Biología" }
        };

        modelBuilder.Entity<Subject>().HasData(subjectsInit.ToArray());
        //    (
        //    Subject =>
        //    {
        //        //Subject.ToTable("Asignatura");
        //        Subject.HasKey(s => s.UniqueId);
        //        Subject.Property(s => s.Name).HasMaxLength(100);
        //        Subject.;
        //    }

        //);

        modelBuilder.Entity<Student>().HasData(
            Student.GenerateStudentRandom().ToArray()
        );

    }
}

