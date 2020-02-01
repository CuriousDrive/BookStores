using BlazorServerApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Services
{
    interface IUserService
    {
        public Task<User> LoginAsync(User user);
        public Task<User> RefreshTokenAsync(RefreshRequest refreshRequest);
    }
}
