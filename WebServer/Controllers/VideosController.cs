using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        private readonly Context _context;
        private IHostingEnvironment _hostingEnvironment;
        public VideosController(Context context , IHostingEnvironment environment)
        {
            _context = context;
            _hostingEnvironment = environment;
        }

        //8
        [HttpPost("GetVideo/{studenId}")]
        public async Task<ActionResult<Video>> GetVideo(Guid videoId , int studenId)
        {
            var video = await _context.Videos.FirstOrDefaultAsync(x => x.Id == videoId);
            if (video == null)
            {
                return Problem("Error Video Code");
            }
            var NotaSerials = _context.NoteBookSerials.Where(x=>x.NoteBookId == video.NoteBookId);
            var StudenNote = await _context.StudentNoteBooks.FirstOrDefaultAsync(x=>x.StudentId == studenId);
            if (StudenNote == null)
            {
                return Problem("This NoteBook Is Used By Another Student");
            }
            if (!StudenNote.IsActive)
            {
                return Problem("Not Active In Your Device");
            }
            return Ok(video);
        }

        //9
        [HttpPost("CheckWatching/{studenId}")]
        public async Task<ActionResult<Video>> CheckWatching(Video video, int studenId)
        {
            var NotaSerials = _context.NoteBookSerials.Where(x => x.NoteBookId == video.NoteBookId);
            var StudenNote = await _context.StudentNoteBooks.FirstOrDefaultAsync(x => x.StudentId == studenId);
            if (StudenNote == null)
            {
                return Problem("This NoteBook Is Used By Another Student");
            }
            if (!StudenNote.IsActive)
            {
                return Problem("Not Active In Your Device");
            }
            await _context.Views.AddAsync(new View
            {
                StudentId = studenId,
                VideoId = video.Id
            });
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("Upload/{fileName}")]
        public async Task<ActionResult<Video>> Upload(string fileName)
        {
            IFormFile file = Request.Form.Files[0];
            var filePath = Path.Combine(@"C:\Users\HP\Desktop\test", file.FileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return Ok();
        }
    }
}
