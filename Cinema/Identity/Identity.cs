using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Cinema.Identity
{
    public class Identity
    {

        ClaimsPrincipal userPrincipal = new ClaimsPrincipal();


        public bool Authenticate(string email, string pass)
        {
            try
            {
                var UserClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,"usuario"),
                new Claim(ClaimTypes.Email,email),
                new Claim(ClaimTypes.Role,"Admin")
            };

                var UserIdentity = new ClaimsIdentity(UserClaims, CookieAuthenticationDefaults.AuthenticationScheme);
                AddIdentity(UserIdentity);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
           
        }


        public void AddIdentity(ClaimsIdentity claimsIdentity)
        {
            userPrincipal.AddIdentity(claimsIdentity);           
        }


        public ClaimsPrincipal GetPrincipal()
        {

            return userPrincipal;
        }


        public string getUserName()
        {
            return userPrincipal.Claims.Where(c => c.Type == ClaimTypes.Name).Select(c => c.Value).SingleOrDefault();
        }


 public string getCorreo()
        {
            return userPrincipal.Claims.Where(c => c.Type == ClaimTypes.Email).Select(c => c.Value).SingleOrDefault();
        }


        public bool ValidSession()
        {
            if (userPrincipal.Identity.IsAuthenticated)
            {
                return true;
            }else
            {
                return false;
            }
           
        }
    }
}
