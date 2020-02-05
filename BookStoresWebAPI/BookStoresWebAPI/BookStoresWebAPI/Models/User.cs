using System;
using System.Collections.Generic;

namespace BookStoresWebAPI.Models
{
    public partial class User
    {
        public User()
        {
            RefreshTokens = new HashSet<RefreshToken>();
        }

        public int UserId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Source { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public short RoleId { get; set; }
        public int PubId { get; set; }
        public DateTime? HireDate { get; set; }

        public virtual Publisher Pub { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}
