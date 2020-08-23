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
    public class StudentNoteBooksController : ControllerBase
    {
        private readonly Context _context;

        public StudentNoteBooksController(Context context)
        {
            _context = context;
        }

        //6
        [HttpPost("SetUpNewNoteBook/{studentId}")]
        public async Task<ActionResult<StudentNoteBook>> SetUpNewNoteBook(Guid noteSerial , int studentId)
        {
            //Check If Serial Fount
            NoteBookSerial noteBookSerial = await _context.NoteBookSerials.FirstOrDefaultAsync(x=>x.NoteSerial == noteSerial);
            if (noteBookSerial == null)
            {
                return Problem("wrong number");
            }
            NoteBook noteBook = await _context.NoteBooks.FirstOrDefaultAsync(x => x.Id == noteBookSerial.NoteBookId);
            if (!noteBook.IsActive)
            {
                return Problem("It stopped working");
            }
            StudentNoteBook studentNoteBook =await _context.StudentNoteBooks.FirstOrDefaultAsync(x => x.SerialId == noteBookSerial.Id);
            if (studentNoteBook != null)
            {
                if (studentNoteBook.StudentId != studentId)
                {
                    return Problem("Used by another student");
                }
                else
                {
                    return Ok(studentNoteBook);
                }
            }
            StudentNoteBook CraetestudentNoteBook = new StudentNoteBook
            {
                StudentId = studentId,
                SerialId = noteBookSerial.Id
            };
            await _context.StudentNoteBooks.AddAsync(CraetestudentNoteBook);
            await _context.SaveChangesAsync();

            return Ok(CraetestudentNoteBook);
        }


        //void test()
        //{
        //    NoteBook noteBook = new NoteBook
        //    {
        //        Id = 1,
        //        ReleaseDate = DateTime.Now,
        //        SubjectId = 2,
        //        IsActive = true,
        //        Note = "Thie for math"
        //    };
        //    NoteBookSerial noteBookSerial1 = new NoteBookSerial
        //    {
        //        Id = 1,
        //        NoteSerial = Guid.NewGuid(),
        //        NoteBookId =1
        //    };
        //    NoteBookSerial noteBookSerial2 = new NoteBookSerial
        //    {
        //        Id = 2,
        //        NoteSerial = Guid.NewGuid(),
        //        NoteBookId = 1
        //    };
        //    StudentNoteBook studentNoteBook = new StudentNoteBook
        //    {
        //        Id = 1 ,
        //        StudentId =1 ,
        //        SerialId = 1
        //    };
        //}

        
    }
}
