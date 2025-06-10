﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Architecture_BookManagementSystem_API_.NET_8.Models.Entities
{
    public class BookGeneres
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
        public bool IsDeleted { get; set; }
    }
}
