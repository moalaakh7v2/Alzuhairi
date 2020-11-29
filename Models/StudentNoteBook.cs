namespace Models
{
    public partial class StudentNoteBook
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int NoteBookSerialId { get; set; }
        public virtual NoteBookSerial NoteBookSerial { get; set; }
        public bool IsActive { get; set; }
    }
}
