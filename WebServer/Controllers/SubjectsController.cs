using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly Context _context;

        public SubjectsController(Context context)
        {
            _context = context;
        }

        //F
        [HttpGet("GetSubjects")]
        public async Task<ActionResult<IEnumerable<Subject>>> GetSubjects()
        {
            var subjects =  await _context.Subjects.Include(x=>x.Dept).ToListAsync();
            foreach (var dept in subjects.Select(x=>x.Dept))
            {
                dept.Subjects = null;
            }
            return subjects;
        }

        //G
        [HttpPost("AddNewSubject")]
        public async Task<ActionResult<Dept>> AddNewDept(Subject subject)
        {
            await _context.Subjects.AddAsync(subject);
            await _context.SaveChangesAsync();

            return Ok(subject);
        }

        //H
        [HttpPost("EditSubject")]
        public async Task<ActionResult<Dept>> EditDept(Subject subject)
        {
            await _context.Subjects.AddAsync(subject);
            await _context.SaveChangesAsync();

            return Ok(subject);
        }

        //I
        [HttpPost("DeleteSubject")]
        public async Task<ActionResult<Dept>> DeleteDept(int subjectId)
        {
            Subject subject = await _context.Subjects.FindAsync(subjectId);
            _context.Subjects.Remove(subject);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
