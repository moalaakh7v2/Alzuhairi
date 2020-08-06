namespace WebServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblUser
    {
        public tblUser()
        {
            tblPhones = new HashSet<tblPhone>();
            tblUserInfos = new HashSet<tblUserInfo>();
        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Gender { get; set; }

        public int Age { get; set; }

        public int IdDept { get; set; }

        public virtual tblDept tblDept { get; set; }
        public virtual ICollection<tblPhone> tblPhones { get; set; }
        public virtual ICollection<tblUserInfo> tblUserInfos { get; set; }
    }
}
