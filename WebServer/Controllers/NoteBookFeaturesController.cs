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
    public class NoteBookFeaturesController : ControllerBase
    {
        private readonly Context _context;

        public NoteBookFeaturesController(Context context)
        {
            _context = context;
        }

        //m
        [HttpGet("GetNoteBookFeatures")]
        public async Task<ActionResult<IEnumerable<NoteBookFeature>>> GetNoteBookFeatures(int noteBookId)
        {
            if (_context.NoteBooks.Any(x=>x.Id == noteBookId))
            {
                return Problem("NoteBook Not Fount");
            }
            return await _context.NoteBookFeatures.Where(x=>x.NoteBookId == noteBookId && x.IsActive).ToListAsync();
        }

        //N
        [HttpPost("AddNoteBookFeatures")]
        public async Task<ActionResult<IEnumerable<NoteBookFeature>>> AddNoteBookFeatures(List<NoteBookFeature> noteBookFeatures)
        {
            await _context.NoteBookFeatures.AddRangeAsync(noteBookFeatures);
            await _context.SaveChangesAsync();
            return Ok(noteBookFeatures);
        }

        //O
        [HttpPost("DeActiveNoteBookFeatures")]
        public ActionResult<IEnumerable<NoteBookFeature>> DeActiveNoteBookFeatures(List<NoteBookFeature> noteBookFeatures)
        {
            foreach (var item in noteBookFeatures)
            {
                item.IsActive = false;
            }
            _context.NoteBookFeatures.UpdateRange(noteBookFeatures);
            _context.SaveChanges();
            return Ok(noteBookFeatures);
        }

    }
}
