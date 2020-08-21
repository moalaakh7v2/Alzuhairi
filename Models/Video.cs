using System;
using System.ComponentModel.DataAnnotations;
namespace Models
{
    public partial class Video
    {
        public Guid Id { get; set; }

        [Required]
        public string Path { get; set; }

        public int NoteBookId { get; set; }

        [Required]
        public string Title { get; set; }

        public virtual NoteBook NoteBook { get; set; }
    }
}
