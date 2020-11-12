﻿using System;
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
    public class SubjectsController : ControllerBase
    {
        private readonly Context _context;

        public SubjectsController(Context context)
        {
            _context = context;
        }

        
        [HttpGet("GetSubjects")]
        public async Task<ActionResult<IEnumerable<Subject>>> GetSubjects()
        {
            var subjects =  await _context.Subjects.Include(x=>x.Dept).ToListAsync();
            foreach (var dept in subjects.Select(x=>x.Dept))
            {
                dept.Subjects = null;
            }
            return subjects;
        }

        
        [HttpPost("AddNewSubject")]
        public async Task<ActionResult<Subject>> AddNewDept(Subject subject)
        {
            await _context.Subjects.AddAsync(subject);
            await _context.SaveChangesAsync();

            return subject;
        }
    }
}
