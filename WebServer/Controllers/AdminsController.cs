using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Tools;

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
            return await _context.Admins.FirstOrDefaultAsync(x => x.Email == admin.Email && x.Password == admin.Password);
        }

        [HttpGet]
        public string Init()
        {
            return "Welcome To Application";
        }
    }
}
