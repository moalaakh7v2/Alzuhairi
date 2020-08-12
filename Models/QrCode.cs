using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public partial class QrCode
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        [Required]
        public string VideoLink { get; set; }
        public string Describe { get; set; }

        public int IdNota { get; set; }

        public virtual Nota tblNota { get; set; }
    }
}
