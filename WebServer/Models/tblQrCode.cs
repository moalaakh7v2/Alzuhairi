namespace WebServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblQrCode
    {
        public Guid Id { get; set; }

        [Required]
        public string VideoLink { get; set; }

        public int IdNota { get; set; }

        public virtual tblNota tblNota { get; set; }
    }
}
