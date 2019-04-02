using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoFotoCore.Filters;

namespace ProyectoFotoCore.Controllers
{
    [AuthorizedUser]
    public class AdminController : Controller
    {
        public IActionResult menu()
        {
            return View();
        }
    }
}