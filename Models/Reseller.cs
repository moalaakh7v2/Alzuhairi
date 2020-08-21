using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Models
{
    public partial class Reseller
    {
        public Reseller()
        {
            NoteBooksSolds = new HashSet<NoteBooksSold>();
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        public virtual ICollection<NoteBooksSold> NoteBooksSolds { get; set; }
    }
}
