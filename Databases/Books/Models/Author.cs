using System;
using System.Collections.Generic;

#nullable disable

namespace Books.Models
{
    public partial class Author
    {
        public Author()
        {
            AuthorIsbns = new HashSet<AuthorIsbn>();
        }

        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<AuthorIsbn> AuthorIsbns { get; set; }
    }
}
