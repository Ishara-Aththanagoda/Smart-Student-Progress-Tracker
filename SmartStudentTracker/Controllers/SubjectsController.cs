using Microsoft.AspNetCore.Mvc;
using SmartStudentTracker.Data;
using SmartStudentTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace SmartStudentTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SubjectsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subject>>> GetSubjects()
        {
            return await _context.Subjects.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Subject>> AddSubject(Subject subject)
        {
            _context.Subjects.Add(subject);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSubjects), new { id = subject.Id }, subject);
        }
    }
}
