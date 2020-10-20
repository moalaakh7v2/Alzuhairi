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

        //Android5
        [HttpPost("SendContact")]
        public async Task<IActionResult> SendContact(Contact contact)
        {
            if (_context.Contacts.Any(x=>x.StudentId == contact.StudentId && x.SendDate.Day == DateTime.Now.Day))
            {
                return Problem("You must wait 24 hours before sending again");
            }
            contact.SendDate = DateTime.Now;
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
