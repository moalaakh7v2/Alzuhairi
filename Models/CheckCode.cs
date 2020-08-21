using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class CheckCode
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public int Code { get; set; }
        public DateTime SendDate { get; set; } = DateTime.Now;
    }
}
