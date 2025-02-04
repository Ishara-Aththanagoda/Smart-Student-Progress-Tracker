using Xunit;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class AuthenticationTests
{
    private readonly HttpClient _client;

    public AuthenticationTests()
    {
        _client = new HttpClient { BaseAddress = new System.Uri("http://localhost:5000") };
    }

    [Fact]
    public async Task Login_ValidUser_ReturnsToken()
    {
        var requestData = JsonConvert.SerializeObject(new { Username = "admin", Password = "password123" });
        var response = await _client.PostAsync("/api/auth/login", new StringContent(requestData, Encoding.UTF8, "application/json"));
        response.EnsureSuccessStatusCode();
    }
}