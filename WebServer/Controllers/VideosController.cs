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
        [HttpPost("RemoveVideo")]
        public async Task<ActionResult<Video>> RemoveVideo(List<Guid> videoIds)
        {
            var videos = await _context.Videos.Where(x => videoIds.Contains(x.Id)).ToListAsync();
            if (!videos.Any())
                return Problem("Error Video Code");
            //todo remove video from server 
            foreach (var item in videos)
                item.IsActive = false;
            await _context.SaveChangesAsync();
            return Ok(new Video ());
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

        [HttpPost("AddVideoToNoteBook/{notebookId}")]
        public async Task<ActionResult<Video>> AddVideo(int notebookId)
        {
            try
            {
                var notebook = _context.NoteBooks
                    .Include(x=>x.Subject).First(x => x.Id == notebookId);
                var VideoPath = VideosPath + "/" + notebook.Subject.SubjectName + "/" + notebook.Id + "/";
                if (!Directory.Exists(VideoPath))
                    Directory.CreateDirectory(VideoPath);
                IFormFile file = Request.Form.Files[0];
                var filePath = Path.Combine(VideoPath, file.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                    await file.CopyToAsync(fileStream);
               // ZipFile.ExtractToDirectory(VideoPath+file.FileName, VideoPath);
             //   System.IO.File.Delete(VideoPath + file.FileName);
                Video video = new Video
                {
                    Id = Guid.NewGuid(),
                    NoteBookId = notebookId,
                    Path = VideosPath + file.FileName,
                    Title = Path.GetFileNameWithoutExtension(file.FileName)
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
