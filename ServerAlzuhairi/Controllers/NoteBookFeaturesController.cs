using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ServerAlzuhairi.Controllers
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

        [HttpGet("GetNoteBookFeatures/{noteBookId}")]
        public async Task<ActionResult<IEnumerable<NoteBookFeature>>> GetNoteBookFeatures(int noteBookId)
        {
            if (_context.NoteBooks.Any(x=>x.Id == noteBookId))
            {
                return Problem("النوطة غير موجودة");
            }
            return await _context.NoteBookFeatures.Where(x=>x.NoteBookId == noteBookId && x.IsActive).ToListAsync();
        }

    }
}
