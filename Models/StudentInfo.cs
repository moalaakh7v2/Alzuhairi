namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("StudentInfos")]
    public partial class StudentInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentInfo()
        {
            RegisterCodes = new HashSet<RegisterCode>();
        }

        public int Id { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Imei { get; set; }

        [Required]
        public string MacAddress { get; set; }

        public int StudentId { get; set; }

        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegisterCode> RegisterCodes { get; set; }

        public virtual Student Student { get; set; }
    }
}
