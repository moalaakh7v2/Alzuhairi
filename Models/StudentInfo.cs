using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Models
{
    public partial class StudentInfo
    {
        public StudentInfo()
        {
            RegisterCodes = new HashSet<RegisterCode>();
        }

        public int Id { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Imei { get; set; }

        public int StudentId { get; set; }

        public bool IsActive { get; set; } = true;
        public virtual ICollection<RegisterCode> RegisterCodes { get; set; }

        public virtual Student Student { get; set; }
    }
}
