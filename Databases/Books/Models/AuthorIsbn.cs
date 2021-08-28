using System;
using System.Collections.Generic;

#nullable disable

namespace Books.Models
{
    public partial class AuthorIsbn
    {
        public int AuthorId { get; set; }
        public string Isbn { get; set; }

        public virtual Author Author { get; set; }
        public virtual Title IsbnNavigation { get; set; }
    }
}
