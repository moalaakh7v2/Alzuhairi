using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Enums;
using Tools;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckCodesController : ControllerBase
    {
        private readonly Context _context;

        public CheckCodesController(Context context)
        {
            _context = context;
        }

        //1
        [HttpPost("CreateCode/{PhoneNumber}")]
        public async Task<ActionResult<CheckCode>> CreateCode(string PhoneNumber)
        {
            if (_context.CheckCodes.Any(x => x.PhoneNumber == PhoneNumber && x.SendDate.AddMinutes(15) <= DateTime.Now))
            {
                return Problem("Please wait 15 minutes before re-requesting the code");
            }
            _context.CheckCodes.Add(new CheckCode {
                PhoneNumber = PhoneNumber,
                Code = RandomeCS.IntRandom()
            });
            await _context.SaveChangesAsync();
            return Ok();
        }

        //2
        [HttpGet("CheckCodeExists/{PhoneNumber}/{Code}")]
        private async Task<ActionResult<RegisterState>> CheckCodeExists(string PhoneNumber , int Code)
        {
            bool state = _context.CheckCodes.Any(x=>x.PhoneNumber == PhoneNumber && x.Code == Code && x.SendDate.AddMinutes(15) <= DateTime.Now);
            if (!state)
                return RegisterState.NoteFound;
            else
            {
                Student student = await _context.Students.FirstOrDefaultAsync(x => x.PhoneNumber == PhoneNumber);
                if (student == null)
                    return RegisterState.unregistered;
                else if (!student.IsActive)
                    return RegisterState.Blocked;
                return RegisterState.AlreadyRegistered;
            }
        }
    }
}
