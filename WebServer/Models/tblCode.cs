namespace WebServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCode
    {
        public int Id { get; set; }

        public int IdPhone { get; set; }

        [Required]
        public string Code { get; set; }

        public DateTime SendDate { get; set; }

        public virtual tblPhone tblPhone { get; set; }
    }
}
