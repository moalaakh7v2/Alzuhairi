namespace WebServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblSubject
    {
        public tblSubject()
        {
            tblNotas = new HashSet<tblNota>();
        }

        public int Id { get; set; }

        [Required]
        public string Subject { get; set; }

        public int IdDept { get; set; }

        public virtual tblDept tblDept { get; set; }
        public virtual ICollection<tblNota> tblNotas { get; set; }
    }
}
