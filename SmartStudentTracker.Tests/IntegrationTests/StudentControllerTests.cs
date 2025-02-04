using Xunit;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using SmartStudentTracker;

public class StudentControllerTests : IClassFixture<WebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;

    public StudentControllerTests(WebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetAllStudents_ReturnsSuccess()
    {
        var response = await _client.GetAsync("/api/students");
        response.EnsureSuccessStatusCode();
    }
}