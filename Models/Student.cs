using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Models
{
    public partial class Student
    {
        public Student()
        {
            StudentInfos = new HashSet<StudentInfo>();
        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Age { get; set; }

        public int DeptId { get; set; }

        public DateTime RegisterDate { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual Dept Dept { get; set; }
        public virtual ICollection<StudentInfo> StudentInfos { get; set; }
    }
}
