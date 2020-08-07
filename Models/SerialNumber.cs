using System;

namespace Models
{
    public partial class SerialNumber
    {
        public int Id { get; set; }

        public Guid Serial { get; set; }

        public int IdNota { get; set; }

        public virtual Nota tblNota { get; set; }
    }
}
