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
    public class NoteBooksController : ControllerBase
    {
        private readonly Context _context;

        public NoteBooksController(Context context)
        {
            _context = context;
        }

        //J
        [HttpGet("GetNoteBooks")]
        public async Task<ActionResult<IEnumerable<NoteBook>>> GetNoteBooks()
        {
            return await _context.NoteBooks.ToListAsync();
        }

        //K
        [HttpGet("CheckNoteBookExists")]
        public bool CheckNoteBookExists(Subject subject)
        {
            return _context.NoteBooks.Any(x => x.SubjectId == subject.Id);
        }

        //L
        [HttpPost("AddNewNoteBook/{count}")]
        public async Task<ActionResult<IEnumerable<NoteBookSerial>>> AddNewNoteBook(NoteBook noteBook , int count)
        {
            noteBook.ReleaseDate = DateTime.Now;
            await _context.NoteBooks.AddAsync(noteBook);
            await _context.SaveChangesAsync();
            List<NoteBookSerial> noteBookSerials = new List<NoteBookSerial>();
            for (int i = 1; i <= count; i++)
            {
                noteBookSerials.Add(new NoteBookSerial
                {
                    NoteBookId = noteBook.Id,
                    NoteSerial = Guid.NewGuid()
                });
            }
            await _context.NoteBookSerials.AddRangeAsync(noteBookSerials);
            await _context.SaveChangesAsync();
            return Ok(noteBookSerials);
        }

    }
}
