using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;


namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private readonly Context _context;

        public AdminsController(Context context)
        {
            _context = context;
        }


        //A
        [HttpPost("LogInAdminAccount")]
        public async Task<ActionResult<Admin>> LogInAdminAccount(Admin admin)
        {
            admin = await _context.Admins.FirstOrDefaultAsync(x => x.Email == admin.Email && x.Password == admin.Password);
            if (admin == null)
            {
                return new Admin ();
            }
            return Ok(admin);
        }

        [HttpGet]
        public Admin Init()
        {
            return new Admin();
        }
    }
}
