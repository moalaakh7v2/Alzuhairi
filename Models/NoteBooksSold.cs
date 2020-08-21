namespace Models
{
    public partial class NoteBooksSold
    {
        public int Id { get; set; }

        public int ResellerId { get; set; }

        public int SerialId { get; set; }

        public virtual NoteBookSerial NoteBookSerial { get; set; }

        public virtual Reseller Reseller { get; set; }
    }
}
