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
    public class ContactsController : ControllerBase
    {
        private readonly Context _context;

        public ContactsController(Context context)
        {
            _context = context;
        }

        //Andorid5
        [HttpPost("SendContact")]
        public async Task<IActionResult> SendContact(Contact contact)
        {
            contact.SendDate = DateTime.Now;
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
            return Ok();
        
        }
    }
}
