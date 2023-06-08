using CourseSignupSystem_BE.Data;
using CourseSignupSystem_BE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseSignupSystem_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly CourseSignupSystemContext _context;

        public StudentController(CourseSignupSystemContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetAll()
        {
            if (_context.Students == null)
            {
                return BadRequest();
            }
            return await _context.Students.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> Get(string id)
        {
            if (id == null) { 
                return BadRequest();
            }
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return student;
        }

        [HttpPost]
        public async Task<ActionResult> Create(Student student)
        {
            if (student == null)
            {
                return BadRequest();
            }
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return Ok(new {message = "Create Successful~"});
        }

        [HttpPut]
        public async Task<ActionResult> Update(Student student)
        {
            if (student == null)
            {
                return BadRequest();
            }
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Update Successful~" });
        }
    }
}
