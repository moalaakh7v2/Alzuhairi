namespace WebServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblNota
    {
        public tblNota()
        {
            tblQrCodes = new HashSet<tblQrCode>();
            tblSerialNumbers = new HashSet<tblSerialNumber>();
        }

        public int Id { get; set; }

        public int IdSubject { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool IsActive { get; set; }

        public virtual tblSubject tblSubject { get; set; }
        public virtual ICollection<tblQrCode> tblQrCodes { get; set; }
        public virtual ICollection<tblSerialNumber> tblSerialNumbers { get; set; }
    }
}
