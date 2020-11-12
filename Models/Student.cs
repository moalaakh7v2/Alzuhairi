using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public partial class Student
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime RegisterDate { get; set; }
        public string PhoneNumber { get; set; }
        public string SchoolName { get; set; }
        public string Mac { get; set; } 
        public bool IsActive { get; set; } = true;
        public virtual ICollection<StudentNoteBook> StudentNoteBooks { get; set; }
    }
}
