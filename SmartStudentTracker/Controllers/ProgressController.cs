using Microsoft.AspNetCore.Mvc;
using SmartStudentTracker.Data;
using SmartStudentTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace SmartStudentTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgressController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProgressController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Progress>> AddProgress(Progress progress)
        {
            _context.ProgressRecords.Add(progress);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProgress), new { id = progress.Id }, progress);
        }

        [HttpGet("{studentId}")]
        public async Task<ActionResult<IEnumerable<Progress>>> GetProgress(int studentId)
        {
            return await _context.ProgressRecords.Where(p => p.StudentId == studentId).ToListAsync();
        }
    }
}
