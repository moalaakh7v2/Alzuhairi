using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly Context _context;

        public StudentsController(Context context)
        {
            _context = context;
        }

        //34
        [HttpGet("GetStudents")]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        //4
        [HttpGet("GetStudent/{imei}")]
        public async Task<ActionResult<Student>> GetStudent(string imei)
        {
            return await _context.Students.FirstOrDefaultAsync(x=>x.Imei == imei);
        }

        //3
        [HttpPost("CreateStudent")]
        public async Task<ActionResult<Student>> CreateStudent(Student student)
        {
            student.RegisterDate = DateTime.Now;
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return Ok(student);
        }

        //5
        [HttpPost("ModifyStudent")]
        public async Task<ActionResult<Student>> ModifyStudent(Student student)
        {
            //Todo Update Phone Number
            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(student);
        }

    }
}
