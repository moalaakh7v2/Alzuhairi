using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
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
            List<NoteBook> noteBooks = await _context.NoteBooks
                .Include(x => x.Subject)
                .ThenInclude(x => x.Dept)
                .Include(x => x.NoteBookFeatures)
                .ThenInclude(x=>x.Feature)
                .Include(x=>x.NoteBookSerials)
                .Include(x=>x.Videos)
                .ToListAsync();
            foreach (var noteBook in noteBooks)
            {
                noteBook.Subject.Dept.Subjects = null;
                noteBook.Subject.NoteBooks = null;
                foreach (var NoteBookFeature in noteBook.NoteBookFeatures)
                    NoteBookFeature.NoteBook = null;
                foreach (var NoteBookSerial in noteBook.NoteBookSerials)
                {
                    NoteBookSerial.NoteBook = null;
                    NoteBookSerial.StudentNoteBooks = _context.StudentNoteBooks.Where(x => x.SerialId == NoteBookSerial.Id).ToList();
                }
                foreach (var Video in noteBook.Videos)
                    Video.NoteBook = null;
            }
            return noteBooks;
        }
        [HttpGet("DeActiveNoteBook/{notebookId}")]
        public async Task<NoteBook> DeActiveNoteBook(int notebookId)
        {
            NoteBook noteBook = await _context.NoteBooks.FirstAsync(x => x.IsActive && x.Id == notebookId);
            if (noteBook != null)
            {
                noteBook.IsActive = false;
                await _context.SaveChangesAsync();
            }
            return noteBook;
        }
        //K
        [HttpGet("CheckNoteBookExists")]
        public bool CheckNoteBookExists(Subject subject)
        {
            return _context.NoteBooks.Any(x => x.SubjectId == subject.Id);
        }

        //L
        [HttpPost("AddNewNoteBook/{count}")]
        public async Task<ActionResult<NoteBook>> AddNewNoteBook(NoteBook noteBook , int count)
        {
            try
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
                        QRcode = Guid.NewGuid()
                    });
                }
                await _context.NoteBookSerials.AddRangeAsync(noteBookSerials);
                await _context.SaveChangesAsync();
                foreach (var item in noteBookSerials)
                {
                    item.NoteBook = null;
                }
                noteBook.NoteBookFeatures = null;
                noteBook.NoteBookSerials = noteBookSerials;
                return Ok(noteBook);
            }
            catch (Exception ex)
            {

                throw;
            }
          
        }

        [HttpPost("AddNewSerialForExistNoteBook/{count}")]
        public async Task<ActionResult<NoteBook>> AddNewSerialForExistNoteBook(NoteBook noteBook, int count)
        {
            try
            {

                List<NoteBookSerial> noteBookSerials = new List<NoteBookSerial>();
                for (int i = 1; i <= count; i++)
                {
                    noteBookSerials.Add(new NoteBookSerial
                    {
                        NoteBookId = noteBook.Id,
                        QRcode = Guid.NewGuid()
                    });
                }
                await _context.NoteBookSerials.AddRangeAsync(noteBookSerials);
                await _context.SaveChangesAsync();
                foreach (var item in noteBookSerials)
                {
                    item.NoteBook = null;
                }
                noteBook.NoteBookFeatures = null;
                noteBook.NoteBookSerials = noteBookSerials;
                return Ok(noteBook);
            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}
