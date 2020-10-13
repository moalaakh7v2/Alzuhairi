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
    public class DeptsController : ControllerBase
    {
        private readonly Context _context;

        public DeptsController(Context context)
        {
            _context = context;
        }
        
        [HttpGet("GetDepts")]
        public async Task<ActionResult<List<Dept>>> GetDepts()
        {
            var depts = await _context.Depts.
                Include(x => x.Subjects)
                .ToListAsync();
            foreach (var dept in depts)
                foreach (var subject in dept.Subjects)
                    subject.Dept = null;
            return depts;
        }

        [HttpPost("AddNewDept")]
        public async Task<ActionResult<Dept>> AddNewDept(Dept dept)
        {
            await _context.Depts.AddAsync(dept);
            await _context.SaveChangesAsync();

            return Ok(dept);
        }

        ////test1
        //[HttpPost("EditDept")]
        //public async Task<ActionResult<Dept>> EditDept(Dept dept)
        //{
        //    await _context.Depts.AddAsync(dept);
        //    await _context.SaveChangesAsync();

        //    return Ok(dept);
        //}

        ////test2
        //[HttpPost("DeleteDept")]
        //public async Task<ActionResult<Dept>> DeleteDept(int deptId)
        //{
        //    Dept dept = await _context.Depts.FindAsync(deptId);
        //    _context.Depts.Remove(dept);
        //    await _context.SaveChangesAsync();
        //    return Ok();
        //}

    }
}
