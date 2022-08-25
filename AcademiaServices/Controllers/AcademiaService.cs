using AcademiaServices.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcademiaServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademiaService : ControllerBase
    {
        private readonly LMSDbContext _context;
        public AcademiaService(LMSDbContext context)
        {
            _context = context;
        }

        //GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            return await _context.Courses.ToListAsync();
        }

        //GET: api/Products/1
        [HttpGet("{Id}")]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);

            if (course== null)
            {
                return NotFound();
            }

            return course;
        }

        //POST: api/Products
        [HttpPost]
        public async Task<ActionResult<Course>> AddCourse(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducts", new { id = course.CourseId }, course);
        }

        //PUT: api/Products/2
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCourse(int id, Course course)
        {
            if (id != course.CourseId)
            {
                return BadRequest();
            }

            _context.Entry(course).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoursesExist(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        //DELETE: api/Products/2
        [HttpDelete("{id}")]
        public async Task<ActionResult<Course>> DeleteCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();

            return course;
        }

        private bool CoursesExist(int id)
        {
            return _context.Courses.Any(e => e.CourseId == id);
        }


        


    }
}
