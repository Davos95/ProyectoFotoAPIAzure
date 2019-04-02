using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoFotoCore.Models;
using ProyectoFotoCore.Repositories;

namespace ProyectoFotoCore.Controllers
{
    public class FrontController : Controller
    {
        IRepositoryComision repoComision;
        IRepositoryPartner repoPartner;
        IRepositoryPhoto repoPhoto;
        IRepositoryWork repoWork;
        IRepositorySesion repoSesion;
        public FrontController(IRepositoryComision repoComision, IRepositoryPartner repoPartner, IRepositoryPhoto repoPhoto, IRepositoryWork repoWork, IRepositorySesion repoSesion)
        {
            this.repoComision = repoComision;
            this.repoPartner = repoPartner;
            this.repoPhoto = repoPhoto;
            this.repoWork = repoWork;
            this.repoSesion = repoSesion;
        }

        public IActionResult Index()
        {
            List<PHOTO_COMPLEX> favoritePhotos = this.repoPhoto.GetFavorites();

            return View(favoritePhotos);
            //return View();
        }
        public IActionResult Admin()
        {
            return RedirectToAction("login", "Login");
        }
    }
}