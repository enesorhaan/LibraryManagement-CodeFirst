﻿using System.Collections.Generic;

namespace LibraryManagement_CodeFirst.Models
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Relational Property

        public virtual List<Book> Books { get; set; }
    }
}