﻿using System;
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
    public class AboutsController : ControllerBase
    {
        private readonly Context _context;

        public AboutsController(Context context)
        {
            _context = context;
        }

        //Android4
        [HttpGet("GetAbout")]
        public ActionResult<About> GetAbout()
        {
            return _context.Abouts.FirstOrDefault();
        }


        [HttpPost("UpdateAbout")]
        public async Task<ActionResult<About>> UpdateAbout(About about)
        {
            _context.Abouts.Update(about);
            await _context.SaveChangesAsync();
            return about;
        }

    }
}
