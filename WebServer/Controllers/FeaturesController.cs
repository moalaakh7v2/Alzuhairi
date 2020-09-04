using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly Context _context;

        public FeaturesController(Context context)
        {
            _context = context;
        }

        [HttpGet("GetFeatures")]
        public async Task<ActionResult<List<Feature>>> GetFeatures()
        {
            return await _context.Features.ToListAsync();
        }

        [HttpPost("AddFeature")]
        public async Task<ActionResult<Feature>> AddFeature(Feature feature)
        {
            _context.Features.Add(feature);
            await _context.SaveChangesAsync();

            return Ok(feature);
        }

    }
}
