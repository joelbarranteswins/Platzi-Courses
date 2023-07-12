using Xunit;
using DependencyInversion.Controllers;
using Moq;
using DependencyInversion;
using System.ComponentModel;
using Xunit.Abstractions;

namespace Api.Tests;


public class StudentTest 
{
    private readonly ITestOutputHelper Trace;

    public StudentTest(ITestOutputHelper trace)
    {
        this.Trace = trace;
    }


    // [Fact]
    // public void GetStudent()
    // {
    //     var studentController = new StudentController();

    //     var resultGetStudents = studentController.Get();

    //     Assert.NotNull(resultGetStudents);
    //     Assert.Equal(3, resultGetStudents.Count());
    // }


    [Fact]
    public void GetStudent()
    {
        var LogbookMock = new Mock<ILogbook>();
        var stundentRepositoryMock = new Mock<IStudentRepository>();
        stundentRepositoryMock.Setup(p=> p.GetAll())
                                        .Returns(new List<Student>()
                                        {
                                            new Student(1, "Pepito Pérez", new List<double>() { 3, 4.5 }),
                                            new Student(2, "Mariana Lopera", new List<double>() { 4, 5 }),
                                            new Student(3, "José Molina", new List<double>() { 2, 3 })
                                        });

        var studentController = new StudentController(stundentRepositoryMock.Object, LogbookMock.Object);

        var resultGetStudents = studentController.Get();

        Assert.NotNull(resultGetStudents);
        Assert.Equal(3, resultGetStudents.Count());
    }

    // [Fact]
    // public void Add()
    // {
    //     var LogbookMock = new Mock<ILogbook>();
    //     var stundentRepositoryMock = new Mock<IStudentRepository>();

    //     var studentController = new StudentController(stundentRepositoryMock.Object, LogbookMock.Object);

    //     var student = new Student(1, "Carlos Pérez", new List<double>() { 4, 6.5 });

    //     studentController.Add(student);

    //     var students = studentController.GetAll();

    //     Trace.WriteLine(students.Count().ToString());
    // }

    [Fact]
    public void AddStudent()
    {
        Mock<IStudentRepository> studentRepositoryMock = new Mock<IStudentRepository>();
        Mock<ILogbook> logbookMock = new Mock<ILogbook>();
        StudentController studentController = new StudentController(studentRepositoryMock.Object, logbookMock.Object);

        var student = new Student(4, "John Doe", new List<double>() { 3.5, 4.0 });
        studentController.Add(student);

        studentRepositoryMock.Verify(repo => repo.Add(student), Times.Once);
        logbookMock.Verify(logbook => logbook.Add($"The Student {student.Fullname} have been added"), Times.Once);
        studentRepositoryMock.Verify(repo => repo.Add(It.Is<Student>(s => s.Fullname == "John Doe")), Times.Once);
    }
}