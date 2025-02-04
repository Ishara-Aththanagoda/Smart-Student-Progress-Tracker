using Xunit;
using SmartStudentTracker.Services;
using SmartStudentTracker.Models;
using System.Collections.Generic;

public class StudentServiceTests
{
    private readonly StudentService _studentService;
    
    public StudentServiceTests()
    {
        _studentService = new StudentService();
    }

    [Fact]
    public void AddStudent_ShouldIncreaseCount()
    {
        var student = new Student { Id = 1, Name = "John Doe" };
        _studentService.AddStudent(student);
        Assert.Single(_studentService.GetAllStudents());
    }
}
