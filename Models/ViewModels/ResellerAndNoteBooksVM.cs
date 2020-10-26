using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModels
{
    public class ResellerAndNoteBooksVM
    {
        public string NoteBookTitle { get; set; }
        public string ResellerTitle { get; set; }
        public int Count { get; set; }
        public DateTime LastGrantDate { get; set; }
    }
}
