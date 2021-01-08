using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModels
{
    public class DisplayStudents
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string PhoneNumber { get; set; }
        public string RegisterDate { get; set; }
        public string IsActive { get; set; }
    }
}
