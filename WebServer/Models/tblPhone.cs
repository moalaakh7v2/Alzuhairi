namespace WebServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblPhone
    {
        public tblPhone()
        {
            tblCodes = new HashSet<tblCode>();
        }

        public int Id { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public int IdUser { get; set; }

        public bool IsActive { get; set; }
        public virtual ICollection<tblCode> tblCodes { get; set; }

        public virtual tblUser tblUser { get; set; }
    }
}
