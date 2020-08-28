using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Models
{
    public partial class Student
    {

        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int DeptId { get; set; }
        public DateTime RegisterDate { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Imei { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual Dept Dept { get; set; }
        public virtual ICollection<StudentNoteBook> StudentNoteBooks { get; set; }
    }
}
