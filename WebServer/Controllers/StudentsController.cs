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

        [HttpGet("test/{testId}/{hello}")]
        public ActionResult<Student> test(int testId , bool hello)
        {
            if (testId == 1)
            {
                return Problem("hello word");
            }
            if (testId == 2)
            {
                return new Student { Id = 2 };
            }
            return Ok(new Student { Id = 2 });

        }
        
        [HttpGet("GetStudents")]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var Students = await _context.Students.Include(x=>x.Dept).Include(x=>x.StudentNoteBooks).ToListAsync();
            foreach (var student in Students)
            {
                student.Dept.Students = null;
                student.Dept.Subjects = null;
                foreach (var StudentNoteBook in student.StudentNoteBooks)
                {
                    StudentNoteBook.Student = null;
                }
            }
            return Students;
        }
        
        [HttpGet("GetStudentsByDeptId/{deptId}")]
        public async Task<ActionResult<List<Student>>> GetStudentsByDeptId(int deptId)
        {
            return await _context.Students.Where(x => x.DeptId == deptId).ToListAsync();
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

        ////test7
        //[HttpGet("GetStudent/{imei}")]
        //public async Task<ActionResult<Student>> GetStudent(string imei)
        //{
        //    return await _context.Students.FirstOrDefaultAsync(x=>x.Imei == imei);
        //}

        //Android3 Android8
        [HttpPost("UpdateStudent/{studentId}")]
        public async Task<ActionResult<Student>> UpdateStudent(Student student, int studentId)
        {
            if (studentId != 0)
                _context.Entry(student).State = EntityState.Modified;
            else
            {
                //todo Get Imei in android
                student.Mac = student.Mac == null ? "" : student.Mac;
                student.RegisterDate = DateTime.Now;
                await _context.Students.AddAsync(student);
            }
            await _context.SaveChangesAsync();
            return Ok(student);
        }

       
        [HttpPost("ModifyStudent/{approve}")]
        public async Task<ActionResult<Student>> ModifyStudent(Student student , bool approve)
        {
            student.IsActive = approve;
            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(student);
        }

    }
}
