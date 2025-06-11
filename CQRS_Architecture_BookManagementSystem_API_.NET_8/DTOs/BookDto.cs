using CQRS_Architecture_BookManagementSystem_API_.NET_8.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Architecture_BookManagementSystem_API_.NET_8.DTOs
{
    public class BookDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[]? Cover { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public int PublishYear { get; set; }
    }
}
