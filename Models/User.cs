using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public partial class User
    {
        public User()
        {
            tblPhones = new HashSet<Phone>();
            tblUserInfos = new HashSet<UserInfo>();
        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Gender { get; set; }

        public int Age { get; set; }

        public int IdDept { get; set; }

        public virtual Dept tblDept { get; set; }
        public virtual ICollection<Phone> tblPhones { get; set; }
        public virtual ICollection<UserInfo> tblUserInfos { get; set; }
    }
}
