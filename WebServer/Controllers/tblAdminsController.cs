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
    public class tblAdminsController : ControllerBase
    {
        private readonly Context db;

        public tblAdminsController(Context context)
        {
            db = context;
        }

        [HttpPost("AdminExists")]
        public bool AdminExists(Admin admin)
        {
            return db.Admins.Any(x=>x.Email == admin.Email && x.Password == admin.Password);
        }
    }
}
