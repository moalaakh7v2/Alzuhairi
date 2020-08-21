namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class NoteBookFeature
    {
        public int Id { get; set; }

        public int NoteBookId { get; set; }

        [Required]
        public string Title { get; set; }

        public bool IsActive { get; set; }

        public virtual NoteBook NoteBook { get; set; }
    }
}
