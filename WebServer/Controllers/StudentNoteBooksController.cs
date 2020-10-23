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

        //Android6
        [HttpPost("SetUpNewNoteBook/{studentId}")]
        public async Task<ActionResult<List<NoteBookFeature>>> SetUpNewNoteBook(Guid noteSerial , int studentId)
        {
            //Check If Serial Found
            NoteBookSerial noteBookSerial = await _context.NoteBookSerials.FirstOrDefaultAsync(x=>x.QRcode == noteSerial);
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
                    studentNoteBook.IsActive = true;
                    await _context.SaveChangesAsync();
                    return Ok(new List<NoteBookFeature>());
                }
            }
            List<StudentNoteBook> studentNoteBooks = await  _context.StudentNoteBooks.Where(x=>x.StudentId == studentId).ToListAsync();
            foreach (var item in studentNoteBooks)
                item.IsActive = false;

            StudentNoteBook CraetestudentNoteBook = new StudentNoteBook
            {
                StudentId = studentId,
                SerialId = noteBookSerial.Id,
                IsActive = true,
            };
            List<NoteBookFeature> noteBookFeatures = await _context.NoteBookFeatures.Where(x => x.NoteBookId == noteBook.Id).ToListAsync();
            await _context.StudentNoteBooks.AddAsync(CraetestudentNoteBook);
            await _context.SaveChangesAsync();
            
            return Ok(noteBookFeatures);
        }
    }
}
