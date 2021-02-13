﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ServerAlzuhairi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentNoteBooksController : ControllerBase
    {
        private readonly Context _context;

        public StudentNoteBooksController(Context context)
        {
            _context = context;
        }

        //Android6
        [HttpPost("SetUpNewNoteBook/{studentId}")]
        public async Task<ActionResult<List<NoteBookFeature>>> SetUpNewNoteBook([FromBody] Guid noteSerial , int studentId)
        {
            //Check If Serial Found
            NoteBookSerial noteBookSerial = await _context.NoteBookSerials.FirstOrDefaultAsync(x=>x.QRcode == noteSerial);
            if (noteBookSerial == null)
            {
                return Problem("رمز خاطئ");
            }
            if (!noteBookSerial.IsActive)
            {
                return Problem("النوطة غير مفعلة");
            }
            NoteBook noteBook = await _context.NoteBooks.FirstOrDefaultAsync(x => x.Id == noteBookSerial.NoteBookId);
            StudentNoteBook studentNoteBook =await _context.StudentNoteBooks.FirstOrDefaultAsync(x => x.NoteBookSerialId == noteBookSerial.Id);
            if (studentNoteBook != null)
            {
                if (studentNoteBook.StudentId != studentId)
                {
                    return Problem("النوطة مستخدمة من طالب آخر");
                }
            }
            List<StudentNoteBook> studentNoteBooks = await  _context.StudentNoteBooks.Where(x=>x.StudentId == studentId).ToListAsync();
            foreach (var item in studentNoteBooks)
                item.IsActive = false;

            StudentNoteBook CraetestudentNoteBook = new StudentNoteBook
            {
                StudentId = studentId,
                NoteBookSerialId = noteBookSerial.Id,
                IsActive = true,
            };
            List<NoteBookFeature> noteBookFeatures = await _context.NoteBookFeatures
                .Where(x => x.NoteBookId == noteBook.Id)
                 .Include(x=>x.Feature)
                .ToListAsync();
                await _context.StudentNoteBooks.AddAsync(CraetestudentNoteBook);
                await _context.SaveChangesAsync();
           
            foreach (var item in noteBookFeatures)
                item.NoteBook = null;
            return noteBookFeatures;
        }
    }
}