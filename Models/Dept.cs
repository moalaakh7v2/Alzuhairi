using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public partial class Dept
    {
        public Dept()
        {
            tblSubjects = new HashSet<Subject>();
            tblUsers = new HashSet<User>();
        }

        public int Id { get; set; }

        [Required]
        public string DeptName { get; set; }
        public virtual ICollection<Subject> tblSubjects { get; set; }
        public virtual ICollection<User> tblUsers { get; set; }
    }
}
