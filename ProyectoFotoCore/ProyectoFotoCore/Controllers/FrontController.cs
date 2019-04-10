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

        public async Task<IActionResult> Index()
        {
            List<PHOTO_COMPLEX> favoritePhotos = await this.repoPhoto.GetFavorites();

            return View(favoritePhotos);
            //return View();
        }
        public IActionResult Admin()
        {
            return RedirectToAction("login", "Login");
        }

        public async Task<IActionResult> Sessions()
        {
            List<SESSION_COMPLEX> sessions = await this.repoSesion.GetSessionsComplex();
            return View(sessions);
        }
        
        public async Task<IActionResult> Photos(int id)
        {
            List<PHOTO> photos = await this.repoPhoto.GetPhotos(id);
            return View(photos);
        }

        public async Task<IActionResult> Comision()
        {
            List<COMISION> comisions = await this.repoComision.GetCOMISIONS();
            return View(comisions);
        }
    }
}