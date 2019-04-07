using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFotoCore.Provider;
using ProyectoFotoCore.Repositories;
using ProyectoFotoCore.Tools;

namespace ProyectoFotoCore.Controllers
{
    public class ImagesController : Controller
    {
        IRepositorySesion repoSesion;
        IRepositoryPhoto repoPhoto;
        PathProv prov;

        RepositoryAzureBlob repository;
        public ImagesController(IRepositorySesion repoS, IRepositoryPhoto repoP, PathProv prov, RepositoryAzureBlob repository)
        {
            this.repoSesion = repoS;
            this.repoPhoto = repoP;
            this.prov = prov;

            this.repository = repository;
        }

        // GET: Images
        public IActionResult UploadImages()
        {
            return View(this.repoSesion.GetSesions());
        }

        [HttpPost]
        public async Task<IActionResult> Upload()
        {
            int idSesion = int.Parse(Request.Form["idSesion"].ToString());
            String sessionName = this.repoSesion.GetSESIONID(idSesion).Name;

            String path = prov.MapPath(Folders.Session, sessionName);

            this.repository.CrearContenedor("s"+idSesion.ToString());

            foreach (IFormFile file in Request.Form.Files)
            {
                //await ToolImage.UploadImage(file, path, null);
                await this.repository.SubirBlob("s" + idSesion.ToString(), file);
                String uri = await this.repository.GetUriBlob("s" + idSesion.ToString(), file.FileName);

                this.repoPhoto.InsertPhoto(file.FileName, idSesion,uri);

                
            }

            return Json(true);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteImages(int idSesion)
        {
            String idPhotos = Request.Form["idPhotos"];

            String[] idArray = idPhotos.Split(',');

            String sessionName = this.repoSesion.GetSESIONID(idSesion).Name;
            String path = prov.MapPath(Folders.Session, sessionName);

            foreach (String id in idArray)
            {
                String namePhoto = this.repoPhoto.GetPhotoById(int.Parse(id)).Picture;
                await this.repository.EliminarBlob("s" + idSesion.ToString(), namePhoto);

                this.repoPhoto.RemovePhotos(int.Parse(id));
            }

            return Json(true);
        }

        [HttpPost]
        public async Task<IActionResult> OrderPhotos()
        {
            String idPhotos = Request.Form["idPhotos"];
            String[] idArray = idPhotos.Split(',');

            for (int i = 0; i < idArray.Length; i++)
            {
                this.repoPhoto.OrderPhotos(int.Parse(idArray[i]), i);
            }
            return Json(true);
        }

        [HttpPost]
        public async Task<IActionResult> MovePhotos(int session)
        {
            String idPhotos = Request.Form["idPhotos"];
            String[] idArray = idPhotos.Split(',');
            String oldSession = Request.Form["oldSession"];

            this.repository.CrearContenedor("s" + session.ToString());

            foreach (String id in idArray)
            {
                int idPhoto = int.Parse(id);
                String imageName = this.repoPhoto.GetPhotoById(idPhoto).Picture;
                await this.repository.MoverBlob("s" + oldSession.ToString(), imageName, "s" + session.ToString());
                String uri = await this.repository.GetUriBlob("s" + session.ToString(), imageName);
                this.repoPhoto.MovePhotosSesion(idPhoto, session,uri);
            }
            return Json(true);
        }

        [HttpPost]
        public async Task<IActionResult> SetFavorite(int idPhoto)
        {
            this.repoPhoto.SetFavorite(idPhoto);
            return Json(true);
        }
        [HttpPost]
        public async Task<IActionResult> UndoFavorite(int idPhoto)
        {
            this.repoPhoto.UndoFavorite(idPhoto);
            return Json(true);
        }

        [HttpPost]
        public async Task<IActionResult> OrderFavorites()
        {
            String idPhotos = Request.Form["idPhotos"];
            String[] idArray = idPhotos.Split(',');

            for (int i = 0; i < idArray.Length; i++)
            {
                this.repoPhoto.OrderFavorite(int.Parse(idArray[i]), i);
            }
            return Json(true);
        }
    }
}