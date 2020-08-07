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
    public class tblUsersController : ControllerBase
    {
        private readonly Context _context;

        public tblUsersController(Context context)
        {
            _context = context;
        }
       
        [HttpGet("GetUsers")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.tblUsers.ToListAsync();
        }

        [HttpGet("GetUser/{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var User = await _context.tblUsers.FindAsync(id);

            if (User == null)
            {
                return NotFound();
            }

            return User;
        }
       
    }
}
