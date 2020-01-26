using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoresWebAPI.Models
{
    public class UserWithToken : User
    {
        public string Token { get; set; }

        public UserWithToken(User user)
        {
            this.UserId = user.UserId;
            this.EmailAddress = user.EmailAddress;            
            this.FirstName = user.FirstName;
            this.MiddleName = user.MiddleName;
            this.LastName = user.LastName;
            this.JobId = user.JobId;
            this.JobLevel = user.JobLevel;
            this.PubId = user.PubId;
            this.HireDate = user.HireDate;
        }
    }
}
