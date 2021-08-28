using System;
using System.Collections.Generic;

#nullable disable

namespace Books.Models
{
    public partial class Title
    {
        public Title()
        {
            AuthorIsbns = new HashSet<AuthorIsbn>();
        }

        public string Isbn { get; set; }
        public string Title1 { get; set; }
        public int EditionNumber { get; set; }
        public string Copyright { get; set; }

        public virtual ICollection<AuthorIsbn> AuthorIsbns { get; set; }
    }
}
