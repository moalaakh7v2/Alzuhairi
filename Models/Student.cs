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
        public int DeptId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Imei { get; set; } 
        public bool IsActive { get; set; } = true;
        public virtual Dept Dept { get; set; }
        public virtual ICollection<StudentNoteBook> StudentNoteBooks { get; set; }
    }
}
