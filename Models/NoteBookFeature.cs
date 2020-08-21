using System.ComponentModel.DataAnnotations;
namespace Models
{
    public partial class NoteBookFeature
    {
        public int Id { get; set; }

        public int NoteBookId { get; set; }

        [Required]
        public string Title { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual NoteBook NoteBook { get; set; }
    }
}
