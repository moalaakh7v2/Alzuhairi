using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Models;


namespace ServerAlzuhairi.Controllers
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


        
        [HttpPost("LogInAdminAccount")]
        public async Task<ActionResult<Admin>> LogInAdminAccount(Admin admin)
        {
            admin = await _context.Admins.FirstOrDefaultAsync(x => x.Email == admin.Email && x.Password == admin.Password);
            if (admin == null)
                return Problem("Incorrect Information");
            await _context.SaveChangesAsync();
            return admin;
        }

        [HttpPost("UpdateAdminInfo/{Id}")]
        public async Task<ActionResult<Admin>> UpdateAdminInfo(Admin admin , int Id)
        {
            _context.Entry(admin).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return admin;
        }

        [HttpGet]
        public string Init()
        {
            return "Welcome To Alzuhairi";
        }
    }
}
