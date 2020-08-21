using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Models
{
    public partial class Subject
    {
        public Subject()
        {
            NoteBooks = new HashSet<NoteBook>();
        }

        public int Id { get; set; }

        [Required]
        public string SubjectName { get; set; }

        public int DeptId { get; set; }

        public virtual Dept Dept { get; set; }
        public virtual ICollection<NoteBook> NoteBooks { get; set; }
    }
}
