using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebServer.Models;

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
        public bool AdminExists(tblAdmin admin)
        {
            return db.tblAdmins.Any(x=>x.UserName == admin.UserName && x.Password == admin.Password);
        }
    }
}
