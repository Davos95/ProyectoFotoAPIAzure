using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.WindowsAzure.Storage.Blob;
using ProyectoFotoCore.Filters;
using ProyectoFotoCore.Models;
using ProyectoFotoCore.Provider;
using ProyectoFotoCore.Repositories;
using ProyectoFotoCore.Tools;

//GETCOMPLEXSESIONBYID


namespace ProyectoFotoCore.Controllers
{

    [AuthorizedUser]
    public class SessionController : Controller
    {
        IRepositoryComision repoComision;
        IRepositorySesion repoSesion;
        IRepositoryPartner repoPartner;
        IRepositoryWork repoWork;
        IRepositoryPhoto repoPhoto;
        PathProv prov;
        RepositoryAzureBlob repoBlob;
        public SessionController(IRepositoryComision repoC, IRepositorySesion repoS, IRepositoryPartner repoP, IRepositoryWork repoW, IRepositoryPhoto repoPh, PathProv prov, RepositoryAzureBlob repoBlob)
        {
            this.repoComision = repoC;
            this.repoSesion = repoS;
            this.repoPartner = repoP;
            this.repoWork = repoW;
            this.repoPhoto = repoPh;
            this.prov = prov;
            this.repoBlob = repoBlob;
        }

        public IActionResult Sesion()
        {
            List<SESSION_COMPLEX> sesions = this.repoSesion.GetSessionsComplex().ToList();
            return View(sesions);
        }


        #region Create Sesion
        // GET: CreateSesion
        public async Task<IActionResult> CreateSesion()
        {
            return View(await this.repoComision.GetCOMISIONS());
        }

        [HttpPost]
        public async Task<IActionResult> CreateSesion(String name, String description, DateTime date, int comision)
        {
            //String path = prov.MapPath(Folders.Session, name);
            //ToolImage.CreateFolder(path);
            this.repoSesion.InsertSesion(name, description, date, comision);
            return RedirectToAction("Sesion");
        }
        #endregion

        public async Task<ActionResult> DeleteSesion(int id, String name)
        {
            this.repoSesion.DeleteSesion(id);
            await this.repoBlob.EliminarContenedor("s" + id);
            return RedirectToAction("Sesion");
        }

        #region Edit Sesion
        public async Task<IActionResult> EditSesion(int id)
        {
            SESSION_COMPLEX sesion = this.repoSesion.GetSessionComplexById(id);

            ViewBag.Date = sesion.DateSesion.ToString("yyyy-MM-dd");
            ViewBag.Comision = await this.repoComision.GetCOMISIONS();
            ViewBag.Partner = await this.repoPartner.GetPartners();
            ViewBag.Work = await this.repoWork.GetWORKs();
            ViewBag.Workers = this.repoSesion.GetPartnerWorkBySesion(id);
            ViewBag.Photos = this.repoPhoto.GetPhotos(id).ToList();
            return View(sesion);
        }

        [HttpPost]
        public async Task<IActionResult> EditSesion(String option, int idSesion, int? idPartner, int? idWork, String name, String description, DateTime? date, int? comision, int? idImage)
        {
            if (option == "ADD")
            {
                this.repoSesion.AddPartnerWorkIntoSesion(idSesion, idPartner.Value, idWork.Value);
            }
            else if (option == "MODIFY")
            {
                String sessionName = this.repoSesion.GetSESIONID(idSesion).Name;
                String path = prov.MapPath(Folders.Session);

                //ToolImage.RenameFolder(path, sessionName, name);
                this.repoSesion.ModifySesion(idSesion, name, description, date.Value, comision.Value);
            }
            else if (option == "SETIMAGE") {
                this.repoSesion.SetImageSession(idSesion, idImage.Value);
            }


            SESSION_COMPLEX sesion = this.repoSesion.GetSessionComplexById(idSesion);
            ViewBag.Date = sesion.DateSesion.ToString("yyyy-MM-dd");
            ViewBag.Comision = await this.repoComision.GetCOMISIONS();

            ViewBag.Partner = await this.repoPartner.GetPartners();
            ViewBag.Work = await this.repoWork.GetWORKs();
            ViewBag.Workers = this.repoSesion.GetPartnerWorkBySesion(idSesion);
            ViewBag.Photos = this.repoPhoto.GetPhotos(idSesion).ToList();
            return View(sesion);
        }


        public IActionResult DeletePartnerWorkFromSesion(int idSesion, int idPartner, int idWork)
        {
            this.repoSesion.DeletePartnerWorkFromSesion(idSesion, idPartner, idWork);

            return RedirectToAction("EditSesion", "Session", new { id = idSesion });
        }
        #endregion

        public async Task<IActionResult> ManagePhotos(int idSesion)
        {
            ViewBag.SessionName = this.repoSesion.GetSESIONID(idSesion).Name;
            ViewBag.Sessions = this.repoSesion.GetSesions().Where(x => x.Id != idSesion).ToList();
            ViewBag.IdSesion = idSesion;

            return View(this.repoPhoto.GetPhotos(idSesion));
        }

        public IActionResult FavoritePhotos()
        {
            List<PHOTO_COMPLEX> favoritePhotos = this.repoPhoto.GetFavorites();
            return View(favoritePhotos);
        }

    }
}