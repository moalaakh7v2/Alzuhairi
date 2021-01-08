using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Enums;

namespace ServerAlzuhairi.Controllers
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
        
        [HttpGet("GetStudents")]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var Students = await _context.Students
                .Include(x=>x.StudentNoteBooks)
                .ThenInclude(x=>x.NoteBookSerial)
                .ThenInclude(x=>x.NoteBook)
                .ThenInclude(x=>x.Subject)
                .ToListAsync();
            foreach (var student in Students)
            {
                foreach (var StudentNoteBook in student.StudentNoteBooks)
                {
                    StudentNoteBook.Student = null;
                    StudentNoteBook.NoteBookSerial.StudentNoteBooks = null;
                    StudentNoteBook.NoteBookSerial.NoteBook.NoteBookSerials = null;
                    StudentNoteBook.NoteBookSerial.NoteBook.Subject.NoteBooks = null;
                }
            }
            return Students;
        }

        //Android9
        [HttpGet("GetStudentByNumber/{phoneNumber}")]
        public async Task<ActionResult<Student>> GetStudentByNumber(string phoneNumber)
        {
            var student = await _context.Students.FirstOrDefaultAsync(x => x.PhoneNumber == phoneNumber);
            if (student == null)
            {
                return Problem("User Not Found");
            }
            return student; 
        }

        //Android3 Android8
        [HttpPost("UpdateStudent/{studentId}")]
        public async Task<ActionResult<Student>> UpdateStudent(Student student, int studentId)
        {
            if (studentId != 0)
                _context.Entry(student).State = EntityState.Modified;
            else
            {
                student.LoginData = DateTime.Now;
                await _context.Students.AddAsync(student);
            }
            await _context.SaveChangesAsync();
            return student;
        }

       
        [HttpPost("ModifyStudent")]
        public async Task<ActionResult<Student>> ModifyStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return student;
        }
    }
}
