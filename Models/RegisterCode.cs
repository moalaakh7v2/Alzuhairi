namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

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
