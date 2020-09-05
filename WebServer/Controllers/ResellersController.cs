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
    public class ResellersController : ControllerBase
    {
        private readonly Context _context;

        public ResellersController(Context context)
        {
            _context = context;
        }

        [HttpGet("GetResellers")]
        public async Task<ActionResult<IEnumerable<Reseller>>> GetResellers()
        {
            return await _context.Resellers.ToListAsync();
        }

        [HttpPost("UpdateReseller")]
        public async Task<ActionResult<Reseller>> UpdateReseller(Reseller reseller)
        {
            _context.Resellers.Update(reseller);
            await _context.SaveChangesAsync();
            return Ok(reseller);
        }
    }
}
