using System;
using System.Collections.Generic;
namespace Models
{
    public partial class NoteBookSerial
    {
        public NoteBookSerial()
        {
            NoteBooksSolds = new HashSet<NoteBooksSold>();
        }
        public int Id { get; set; }

        public Guid NoteSerial { get; set; }

        public int NoteBookId { get; set; }

        public virtual NoteBook NoteBook { get; set; }
        public virtual ICollection<NoteBooksSold> NoteBooksSolds { get; set; }
        public virtual ICollection<StudentNoteBook> StudentNoteBooks { get; set; }
    }
}
