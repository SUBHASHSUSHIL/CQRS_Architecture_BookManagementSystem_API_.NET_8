﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Architecture_BookManagementSystem_API_.NET_8.Models.Entities
{
    public class User
    {
        public Guid Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? Phone { get; set; }
        public byte[]? Photo { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string? EmailConformationToken { get; set; }
        public DateTime? EmailConfirmationTokenExpiration { get; set; }
        public bool IsToken { get; set; }
        public IEnumerable<UserRoles> UserRoles { get; set; }
        public IEnumerable<Review>? Reviews { get; set; }
        public IEnumerable<Favorite>? Favorites { get; set; }
        public IEnumerable<UserBooks>? UserBooks { get; set; }
        public List<RefreshToken>? RefreshTokens { get; set; }
    }
}
