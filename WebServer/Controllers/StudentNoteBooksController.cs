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
    public class StudentNoteBooksController : ControllerBase
    {
        private readonly Context _context;

        public StudentNoteBooksController(Context context)
        {
            _context = context;
        }

        
        [HttpPost("SetUpNewNoteBook")]
        public async Task<ActionResult<IEnumerable<StudentNoteBook>>> SetUpNewNoteBook(StudentNoteBook studentNoteBook)
        {
            if (_context.StudentNoteBooks.Any(x=>x.SerialId == studentNoteBook.SerialId))
            {
                return Problem("The number was entered from another student");
            }
            if (true)
            {

            }
            return await _context.StudentNoteBooks.ToListAsync();
        }

        
    }
}
