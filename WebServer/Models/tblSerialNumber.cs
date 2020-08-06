namespace WebServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblSerialNumber
    {
        public int Id { get; set; }

        public Guid SerialNumber { get; set; }

        public int IdNota { get; set; }

        public virtual tblNota tblNota { get; set; }
    }
}
