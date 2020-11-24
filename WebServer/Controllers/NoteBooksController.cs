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

        
        [HttpGet("GetNoteBooks")]
        public async Task<ActionResult<IEnumerable<NoteBook>>> GetNoteBooks()
        {
            List<NoteBook> noteBooks = await _context.NoteBooks
                .Include(x => x.Subject)
                .Include(x => x.NoteBookFeatures)
                .ThenInclude(x=>x.Feature)
                .Include(x=>x.NoteBookSerials)
                .Include(x=>x.Videos)
                .ToListAsync();
            foreach (var noteBook in noteBooks)
            {
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

        [HttpPost("GetNotebook/{test}")]
        public async Task<ActionResult<NoteBookSerial>> GetNotebook([FromBody] Guid qr , bool test)
        {
            var noteBookSerial = await _context.NoteBookSerials.FirstOrDefaultAsync(x => x.QRcode == qr);
            if (noteBookSerial == null)
            {
                return Problem("Note Found");
            }
            return noteBookSerial;
        }
        [HttpGet("DeActiveNoteBook/{notebookId}")]
        public async Task<ActionResult<NoteBook>> DeActiveNoteBook(int notebookId)
        {
            var noteBookSerialIds = _context.NoteBookSerials.Where(x => x.NoteBookId == notebookId && x.IsActive).Select(x => x.Id).ToList();
            var usingNoteBook = await _context.StudentNoteBooks.Where(x => noteBookSerialIds.Contains(x.Id))
                .Include(x => x.NoteBookSerial)
                .Select(x => x.NoteBookSerial)
                .ToListAsync();
            foreach (var item in usingNoteBook)
            {
                item.IsActive = false;
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
            }
            NoteBook noteBook = new NoteBook();
            return Ok(noteBook);
        }

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
