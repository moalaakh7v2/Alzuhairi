namespace WebServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUserInfos")]
    public partial class tblUserInfo
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        [Required]
        public string Mac { get; set; }

        [Required]
        public string Ip { get; set; }

        [Required]
        public string Agent { get; set; }

        public virtual tblUser tblUser { get; set; }
    }
}
