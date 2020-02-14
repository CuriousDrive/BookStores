using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServerApp.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Twitter;
using Microsoft.AspNetCore.Mvc;

namespace BlazorServerApp.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        [HttpGet("user")]
        public TwitterUser GetUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                TwitterUser twitterUser = new TwitterUser();
                twitterUser.Name = User.Identity.Name;
                
                return twitterUser;
            }
            else
                return null;
        }

        [HttpGet("user/signintwitter")]
        public async Task SigninTwitter()
        {
            await HttpContext.ChallengeAsync(
                TwitterDefaults.AuthenticationScheme,
                new AuthenticationProperties { RedirectUri = "/twitterprofile" });            
        }
    }
}