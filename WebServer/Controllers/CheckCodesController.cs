using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Enums;
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

        //Android1
        [HttpPost("CreateCode")]
        public async Task<ActionResult<CheckCode>> CreateCode([FromBody] string PhoneNumber)
        {
            if (_context.CheckCodes.Any(x => x.PhoneNumber == PhoneNumber && x.SendDate.AddMinutes(15) >= DateTime.Now))
            {
                return Problem("Please wait 15 minutes before re-requesting the code");
            }
            CheckCode checkCode = new CheckCode
            {
                PhoneNumber = PhoneNumber,
                Code = RandomeCS.IntRandom(),
                SendDate = DateTime.Now
            };
            _context.CheckCodes.Add(checkCode);
            await _context.SaveChangesAsync();
            //todo Send MTN Code 
            return checkCode;
        }

        //Android2
        [HttpPost("CheckCodeExists/{z}")]
        public async Task<ActionResult<RegisterState>> CheckCodeExists(CheckCode checkCode , int z)
        {
            bool state = _context.CheckCodes.Any(x=>x.PhoneNumber == checkCode.PhoneNumber && x.Code == checkCode.Code);
            if (!state)
                return RegisterState.NoteFound;
            else
            {
                Student student = await _context.Students.FirstOrDefaultAsync(x => x.PhoneNumber == checkCode.PhoneNumber);
                if (student == null)
                    return RegisterState.unregistered;
                else if (!student.IsActive)
                    return RegisterState.Blocked;
                return RegisterState.AlreadyRegistered;
            }
        }
    }
}
