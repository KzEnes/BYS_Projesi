using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using VeriTabaniProjesi.Context;
using VeriTabaniProjesi.Models;

namespace VeriTabaniProjesi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ProjectContext _context;

        public StudentController(ProjectContext context)
        {
            _context = context;
        }

        //öğrencileri çeker
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents()
        {
            var students = await _context.student.ToListAsync();
            return Ok(students);

        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Student loginDetails)
        {
           
            var student = await _context.student
                                         .FirstOrDefaultAsync(s => s.student_ID == loginDetails.student_ID && s.password == loginDetails.password);

            if (student == null)
            {
                // Eğer öğrenci bulunamazsa, "Öğrenci bulunamadı" mesajını döndürüyoruz
                return NotFound("Öğrenci bulunamadı");
            }

            // Öğrenci bulunduysa, "Öğrenci bulundu" mesajını döndürüyoruz
            return Ok("Öğrenci bulundu");
        }

        // POST: api/Students
        /*[HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student student)
        {
            // Öğrenci objesini veritabanına ekler
            _context.student.Add(student);

            // Değişiklikleri veritabanına kaydeder (insert işlemi)
            await _context.SaveChangesAsync();

            // Başarıyla kaydedilen öğrenciyi döndürür
            // "GetStudent" metodunu çağırarak yeni öğrencinin detaylarına yönlendirir

            return Ok();
        }*/
    }
}
