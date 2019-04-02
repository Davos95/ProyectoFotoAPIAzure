using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using ProyectoFotoCore.Filters;
using ProyectoFotoCore.Models;
using ProyectoFotoCore.Repositories;

namespace ProyectoFotoCore.Controllers
{
    public class LoginController : Controller
    {
        IRepositoryLogin repo;
        public LoginController(IRepositoryLogin repo)
        {
            this.repo = repo;
        }


        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> login(String nick, String password )
        {
            USER user = this.repo.GetUser(nick, password);
            if(user != null)
            {
                ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                identity.AddClaim(new Claim(ClaimTypes.Name, user.Name));
                identity.AddClaim(new Claim(ClaimTypes.Role, "ADMINISTRATOR"));
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties { IsPersistent = true, ExpiresUtc = DateTime.Now.AddMinutes(30) });
                return RedirectToAction("menu","Admin");
            }

            return View();
        }

        public async Task<IActionResult> CerrarSesion()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("login", "Login");
        }

    }
}