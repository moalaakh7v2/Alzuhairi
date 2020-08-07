using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public partial class Subject
    {
        public Subject()
        {
            tblNotas = new HashSet<Nota>();
        }

        public int Id { get; set; }

        [Required]
        public string SubjectName { get; set; }

        public int IdDept { get; set; }

        public virtual Dept tblDept { get; set; }
        public virtual ICollection<Nota> tblNotas { get; set; }
    }
}
