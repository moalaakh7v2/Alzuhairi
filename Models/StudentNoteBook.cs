namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class StudentNoteBook
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int SerialId { get; set; }
    }
}
