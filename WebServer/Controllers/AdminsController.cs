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


        
        [HttpPost("LogInAdminAccount")]
        public async Task<ActionResult<Admin>> LogInAdminAccount(Admin admin)
        {
            admin = await _context.Admins.FirstOrDefaultAsync(x => x.Email == admin.Email && x.Password == admin.Password);
            if (admin == null)
            {
                return new Admin ();
            }
            admin.Token = Guid.NewGuid();
            await _context.SaveChangesAsync();
            return Ok(admin);
        }

        [HttpPost("UpdateAdminInfo/{token}")]
        public async Task<ActionResult<Admin>> UpdateAdminInfo(Admin admin , Guid token)
        {
            Admin GetAdmin = await _context.Admins.FirstOrDefaultAsync(x=>x.Token == token);
            if (GetAdmin != null)
            {
                GetAdmin.Password = admin.Password;
                GetAdmin.Email = admin.Email;
                GetAdmin.Token = admin.Token;
                await _context.SaveChangesAsync();
            }
            return GetAdmin;
        }

        [HttpGet]
        public string Init()
        {
            return "Welcome To Alzuhairi";
        }
    }
}
