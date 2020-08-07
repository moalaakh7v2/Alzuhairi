using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public partial class Code
    {
        public int Id { get; set; }

        public int IdPhone { get; set; }

        [Required]
        public string CodeNum { get; set; }

        public DateTime SendDate { get; set; }

        public virtual Phone tblPhone { get; set; }
    }
}
