using Xunit;
using SmartStudentTracker.Services;
using SmartStudentTracker.Models;

public class ProgressTrackerTests
{
    private readonly ProgressTrackerService _progressService;
    
    public ProgressTrackerTests()
    {
        _progressService = new ProgressTrackerService();
    }

    [Fact]
    public void TrackProgress_ShouldReturnValidData()
    {
        var progress = _progressService.GetProgress(1);
        Assert.NotNull(progress);
    }
}