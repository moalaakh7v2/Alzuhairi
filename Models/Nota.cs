using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Nota
    {
        public Nota()
        {
            tblQrCodes = new HashSet<QrCode>();
            tblSerialNumbers = new HashSet<SerialNumber>();
        }

        public int Id { get; set; }

        public int IdSubject { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual Subject tblSubject { get; set; }
        public virtual ICollection<QrCode> tblQrCodes { get; set; }
        public virtual ICollection<SerialNumber> tblSerialNumbers { get; set; }
    }
}
