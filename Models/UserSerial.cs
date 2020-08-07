using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public partial class UserSerial
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        public int IdUserNota { get; set; }

        public DateTime PurchaseDate { get; set; }
    }
}
