namespace WebServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDept
    {
        public tblDept()
        {
            tblSubjects = new HashSet<tblSubject>();
            tblUsers = new HashSet<tblUser>();
        }

        public int Id { get; set; }

        [Required]
        public string Dept { get; set; }
        public virtual ICollection<tblSubject> tblSubjects { get; set; }
        public virtual ICollection<tblUser> tblUsers { get; set; }
    }
}
