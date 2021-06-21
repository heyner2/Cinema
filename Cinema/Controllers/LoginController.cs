using Cinema.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Identity;
using System.Security.Claims;

namespace Cinema.Controllers
{
    public class LoginController : Controller
    {
         private Identity.Identity _identity;      

        public List<Users> usuarios;
        public LoginController(Identity.Identity Identity)
        {
            usuarios = new List<Users>() {
            new Users("Heyner","123","admin"),
             new Users("Mario","1233","agent"),
                new Users("Lucia","1233","Vendedora")
            };
            _identity = Identity;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(string email, string contra)
        {


           if( _identity.Authenticate(email, contra))
            {
                HttpContext.SignInAsync(_identity.GetPrincipal());

            }

            var identity = _identity.GetPrincipal().Identity;
            
            return View();

            
        }

        public IActionResult LogOut()
        {


            if (_identity.ValidSession())
            {
                HttpContext.SignOutAsync();

            }

            return View("Login");


        }


        [HttpGet]
        [Authorize]
        public IActionResult Secure()
        {
           ViewBag.username= _identity.getUserName();
            
            return View();
        }
    }

}
