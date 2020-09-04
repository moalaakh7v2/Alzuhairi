using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class StoreAndNoteBook
    {
        public int Id { get; set; }
        public int CountSerial { get; set; }
        public DateTime GrantDate { get; set; }
        public int NoteBookId { get; set; }
        public virtual NoteBook NoteBook { get; set; }
        public int ResellerId { get; set; }
        public virtual Reseller Reseller { get; set; }
    }
}
