using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public partial class QrCode
    {
        public Guid Id { get; set; }

        [Required]
        public string VideoLink { get; set; }

        public int IdNota { get; set; }

        public virtual Nota tblNota { get; set; }
    }
}
