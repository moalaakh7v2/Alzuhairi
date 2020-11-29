using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using System.IO;
using Library;
using Microsoft.AspNetCore.Hosting;
using System.IO.Compression;

namespace ServerAlzuhairi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly Context _context;
        public FilesController(Context context)
        {
            _context = context;
        }

        //Android7
        [HttpPost("GetVideo/{studenId}")]
        public async Task<ActionResult<Models.File>> GetVideo([FromRoute] Guid videoId, int studenId)
        {
            var video = await _context.Files.FirstOrDefaultAsync(x => x.Id == videoId);
            if (video == null)
            {
                return Problem("خطأ في رمز الفديو");
            }
            var studentNoteBooks = await _context.StudentNoteBooks.Where(x=>x.StudentId == studenId).Distinct().ToListAsync();
            if (studentNoteBooks.Any())
            {
                return Problem("أنت لاتمتلك النوطة الخاصة بالفديو");
            }
            foreach (var studentNoteBook in studentNoteBooks)
            {
                if (studentNoteBook.NoteBookSerial.NoteBookId == video.NoteBookId)
                {
                    if (studentNoteBook.IsActive)
                    {

                        return video;
                    }
                    return Problem("هذا الفيديو تابع لنوطة غير مفعلة");
                }
            }
            return Problem("أنت لاتمتلك نوطة تتضمن هذا الفديو");
        }

        [HttpPost("RemoveVideo")]
        public async Task<ActionResult<Models.File>> RemoveVideo(List<Guid> videoIds)
        {
            var videos = await _context.Files.Where(x => videoIds.Contains(x.Id)).ToListAsync();
            if (!videos.Any())
                return Problem("Error Video Code");
            foreach (var item in videos)
                item.IsActive = false;
            await _context.SaveChangesAsync();
            return new Models.File ();
        }

        [HttpPost("AddFile")]
        public async Task<ActionResult<Models.File>> AddFile([FromBody]Models.File file)
        {
            try
            {
                await _context.Files.AddAsync(file);
                await _context.SaveChangesAsync();
                file.NoteBook = null;
                return file;
            }
            catch
            {
                return Problem("Error In Save Video Task");
            }
        }
    }
}
