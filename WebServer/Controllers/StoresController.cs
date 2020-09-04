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
    public class StoresController : ControllerBase
    {
        private readonly Context _context;

        public StoresController(Context context)
        {
            _context = context;
        }

        
        //[HttpPost("AddNewStore")]
        //public async Task<ActionResult<Store>> AddNewStore(Store store)
        //{
        //    _context.Stores.Add(store);
        //    await _context.SaveChangesAsync();

        //    return store;
        //}

    }
}
