using System.Collections.Generic;
using SmartStudentTracker.Models;

public static class MockDataGenerator
{
    public static List<Student> GetMockStudents()
    {
        return new List<Student>
        {
            new Student { Id = 1, Name = "Alice" },
            new Student { Id = 2, Name = "Bob" }
        };
    }
}