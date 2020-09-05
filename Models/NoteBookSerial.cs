using System;
using System.Collections.Generic;
namespace Models
{
    public partial class NoteBookSerial
    {
        public int Id { get; set; }
        public Guid QRcode { get; set; }
        public int NoteBookId { get; set; }
        public virtual NoteBook NoteBook { get; set; }
        public virtual ICollection<StudentNoteBook> StudentNoteBooks { get; set; }
    }
}
