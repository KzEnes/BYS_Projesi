using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeriTabaniProjesi.Context;
using VeriTabaniProjesi.Models;

namespace VeriTabaniProjesi.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class InstructorController : ControllerBase
    //{
    //    private readonly ProjectContext _context;

    //    public InstructorController(ProjectContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/Instructors
    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<Instructor>>> Getinstructor()
    //    {
    //        return await _context.instructor.ToListAsync();
    //    }

    //    // GET: api/Instructors/5
    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<Instructor>> GetInstructor(int id)
    //    {
    //        var instructor = await _context.instructor.FindAsync(id);

    //        if (instructor == null)
    //        {
    //            return NotFound();
    //        }

    //        return instructor;
    //    }

    //    // PUT: api/Instructors/5
    //    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutInstructor(int id, Instructor instructor)
    //    {
    //        if (id != instructor.instructor_ID)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(instructor).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!InstructorExists(id))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }

    //        return NoContent();
    //    }

    //    // POST: api/Instructors
    //    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    //    [HttpPost]
    //    public async Task<ActionResult<Instructor>> PostInstructor(Instructor instructor)
    //    {
    //        _context.instructor.Add(instructor);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetInstructor", new { id = instructor.instructor_ID }, instructor);
    //    }

    //    // DELETE: api/Instructors/5
    //    [HttpDelete("{id}")]
    //    public async Task<IActionResult> DeleteInstructor(int id)
    //    {
    //        var instructor = await _context.instructor.FindAsync(id);
    //        if (instructor == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.instructor.Remove(instructor);
    //        await _context.SaveChangesAsync();

    //        return NoContent();
    //    }

    //    private bool InstructorExists(int id)
    //    {
    //        return _context.instructor.Any(e => e.instructor_ID == id);
    //    }
    //}
    [Route("api/[controller]")]
    public class InstructorController: ControllerBase
    {

    }
}
