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
    public class tblCodesController : ControllerBase
    {
        private readonly Context _context;

        public tblCodesController(Context context)
        {
            _context = context;
        }

    }
}
