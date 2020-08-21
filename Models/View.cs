namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class View
    {
        public Guid Id { get; set; }

        public int StudentId { get; set; }

        public Guid VideoId { get; set; }
    }
}
