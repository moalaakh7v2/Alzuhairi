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

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        private readonly Context _context;
        string VideosPath = "Uploads/";
        public VideosController(Context context)
        {
            _context = context;
        }

        //Android7
        [HttpPost("GetVideo/{studenId}")]
        public async Task<ActionResult<Video>> GetVideo([FromRoute] Guid videoId, int studenId)
        {
            var video = await _context.Videos.FirstOrDefaultAsync(x => x.Id == videoId);
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
        public async Task<ActionResult<Video>> RemoveVideo(List<Guid> videoIds)
        {
            var videos = await _context.Videos.Where(x => videoIds.Contains(x.Id)).ToListAsync();
            if (!videos.Any())
                return Problem("Error Video Code");
            foreach (var item in videos)
                item.IsActive = false;
            await _context.SaveChangesAsync();
            return Ok(new Video ());
        }

        [HttpPost("AddVideo/{notebookId}/{videoName}")]
        public async Task<ActionResult<Video>> AddVideo([FromBody] string path, int notebookId, string videoName)
        {
            try
            {
                Video video = new Video
                {
                    Id = Guid.NewGuid(),
                    NoteBookId = notebookId,
                    Path = path,
                    Title = videoName,
                    IsActive = true
                };
                await _context.Videos.AddAsync(video);
                await _context.SaveChangesAsync();
                video.NoteBook = null;
                return Ok(video);
            }
            catch
            {
                return Problem("Error In Save Video Task");
            }
        }
    }
}
