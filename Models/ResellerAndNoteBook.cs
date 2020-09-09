using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ResellerAndNoteBook
    {
        public int Id { get; set; }
        public int NoteBookId { get; set; }
        public virtual NoteBook NoteBook { get; set; }
        public int ResellerId { get; set; }
        public virtual Reseller Reseller { get; set; }
        public int Count { get; set; }
        public DateTime LastGrantDate { get; set; }
        
    }
}
