using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("tblUserInfos")]
    public partial class UserInfo
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        [Required]
        public string Mac { get; set; }

        [Required]
        public string Ip { get; set; }

        [Required]
        public string Agent { get; set; }

        public virtual User tblUser { get; set; }
    }
}
