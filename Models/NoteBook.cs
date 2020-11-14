using System;
using System.Collections.Generic;
namespace Models
{
    public partial class NoteBook
    {
        public NoteBook()
        {
            NoteBookFeatures = new HashSet<NoteBookFeature>();
            NoteBookSerials = new HashSet<NoteBookSerial>();
            Videos = new HashSet<Video>();
        }

        public int Id { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual ICollection<NoteBookFeature> NoteBookFeatures { get; set; }
        public virtual ICollection<NoteBookSerial> NoteBookSerials { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
        public string Title => Subject.SubjectName + " " + Subject.Dept.ToString() + " " + Subject.Chapter.ToString();
    }
}