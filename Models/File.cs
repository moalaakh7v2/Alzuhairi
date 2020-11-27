using System;
using System.ComponentModel.DataAnnotations;
namespace Models
{
    public partial class File
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public int NoteBookId { get; set; }
        public virtual NoteBook NoteBook { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsVideo { get; set; } 
    }
}
