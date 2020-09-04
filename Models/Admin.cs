using System;
using System.ComponentModel.DataAnnotations;
namespace Models
{
    public partial class Admin
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public Guid Token { get; set; }
    }
}
