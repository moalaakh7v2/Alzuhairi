using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public partial class Phone
    {
        public Phone()
        {
            tblCodes = new HashSet<Code>();
        }

        public int Id { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public int IdUser { get; set; }

        public bool IsActive { get; set; }
        public virtual ICollection<Code> tblCodes { get; set; }

        public virtual User tblUser { get; set; }
    }
}
