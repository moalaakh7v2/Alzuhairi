using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    public class AboutsController : ControllerBase
    {
        private readonly Context _context;

        public AboutsController(Context context)
        {
            _context = context;
        }

        [HttpGet("GetAbout")]
        public ActionResult<About> GetAbout()
        {
            return _context.Abouts.FirstOrDefault();
        }
        [HttpPost("UpdateAbout/{token}")]
        public async Task<ActionResult<About>> UpdateAbout(About about , Guid token)
        {
            if (_context.Admins.Any(x=>x.Token == token))
            {
                _context.Abouts.Update(about);
                await _context.SaveChangesAsync();
            }
            return new About();
        }

    }
}
