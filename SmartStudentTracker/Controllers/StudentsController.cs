using Microsoft.AspNetCore.Mvc;
using SmartStudentTracker.Data;
using SmartStudentTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace SmartStudentTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.Include(s => s.ProgressRecords).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Student>> AddStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetStudents), new { id = student.Id }, student);
        }
    }
}
