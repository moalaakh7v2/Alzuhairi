using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

    }
}
