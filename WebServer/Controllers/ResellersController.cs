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
    public class ResellersController : ControllerBase
    {
        private readonly Context _context;

        public ResellersController(Context context)
        {
            _context = context;
        }

        [HttpGet("GetResellers")]
        public async Task<ActionResult<IEnumerable<Reseller>>> GetResellers()
        {
            return await _context.Resellers.ToListAsync();
        }

        [HttpGet("GetResellerAndNoteBookByResellerId/{resellerId}")]
        public async Task<ActionResult<IEnumerable<ResellerAndNoteBook>>> GetResellerAndNoteBookByResellerId(int resellerId)
        {
            var resellerAndNoteBooks = await _context.ResellerAndNoteBooks.Where(x => x.ResellerId == resellerId)
                .Include(x=>x.NoteBook)
                .ThenInclude(x=>x.Subject)
                .ThenInclude(x=>x.Dept)
                .Include(x=>x.Reseller)
                .ToListAsync();
            foreach (var item in resellerAndNoteBooks)
            {
                item.NoteBook.Subject.NoteBooks = null;
                item.NoteBook.Subject.Dept.Subjects = null;
            }
            return resellerAndNoteBooks;
        }

        [HttpPost("UpdateReseller")]
        public async Task<ActionResult<Reseller>> UpdateReseller(Reseller reseller)
        {
            _context.Resellers.Update(reseller);
            await _context.SaveChangesAsync();
            return Ok(reseller);
        }

        [HttpPost("GrantNoteBooksToReseller/{resellerId}/{noteBookId}/{count}")]
        public async Task<ActionResult<ResellerAndNoteBook>> GrantNoteBooksToReseller(int resellerId,int noteBookId , int count)
        {
            ResellerAndNoteBook resellerAndNoteBook = _context.ResellerAndNoteBooks.FirstOrDefault(x => x.NoteBookId == noteBookId && x.ResellerId== resellerId);
            if (resellerAndNoteBook == null)
            {
                _context.ResellerAndNoteBooks.Add(new ResellerAndNoteBook
                {
                    ResellerId = resellerId,
                    Count = count,
                    NoteBookId = noteBookId,
                    LastGrantDate= DateTime.Now
                });
            }
            else
            {
                resellerAndNoteBook.Count += count;
                resellerAndNoteBook.LastGrantDate = DateTime.Now;
            }
            await _context.SaveChangesAsync();
            return Ok(resellerAndNoteBook);
        }
    }
}
