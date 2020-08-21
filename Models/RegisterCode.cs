using System;
using System.ComponentModel.DataAnnotations;
namespace Models
{
    public partial class RegisterCode
    {
        public Guid Id { get; set; }

        [Required]
        public string Code { get; set; }

        public int PhoneId { get; set; }

        public DateTime SendDate { get; set; }

        public virtual StudentInfo StudentInfo { get; set; }
    }
}
