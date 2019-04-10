using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFotoCore.Filters;
using ProyectoFotoCore.Models;
using ProyectoFotoCore.Provider;
using ProyectoFotoCore.Repositories;
using ProyectoFotoCore.Tools;

namespace ProyectoFotoCore.Controllers
{
    [AuthorizedUser]
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
        public async Task<IActionResult> UploadImages()
        {
            return View(await this.repoSesion.GetSesions());
        }

        [HttpPost]
        public async Task<IActionResult> Upload()
        {
            String token = HttpContext.User.FindFirst(ClaimTypes.Role).Value;

            int idSesion = int.Parse(Request.Form["idSesion"].ToString());
            SESSION session = await this.repoSesion.GetSESIONID(idSesion);
            String sessionName = session.Name;

            this.repository.CrearContenedor("s"+idSesion.ToString());

            foreach (IFormFile file in Request.Form.Files)
            {
                await this.repository.SubirBlob("s" + idSesion.ToString(), file);
                String uri = await this.repository.GetUriBlob("s" + idSesion.ToString(), file.FileName);
                await this.repoPhoto.InsertPhoto(file.FileName, idSesion, uri, token);

            }

            return Json(true);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteImages(int idSesion)
        {
            String token = HttpContext.User.FindFirst(ClaimTypes.Role).Value;

            String idPhotos = Request.Form["idPhotos"];

            String[] idArray = idPhotos.Split(',');

            SESSION session = await this.repoSesion.GetSESIONID(idSesion);

            String sessionName = session.Name;
            String path = prov.MapPath(Folders.Session, sessionName);

            foreach (String id in idArray)
            {
                PHOTO photo = await this.repoPhoto.GetPhotoById(int.Parse(id));
                String namePhoto = photo.Picture;

                await this.repository.EliminarBlob("s" + idSesion.ToString(), namePhoto);

                await this.repoPhoto.RemovePhotos(int.Parse(id), token);
            }

            return Json(true);
        }

        [HttpPost]
        public async Task<IActionResult> OrderPhotos()
        {
            String token = HttpContext.User.FindFirst(ClaimTypes.Role).Value;

            String idPhotos = Request.Form["idPhotos"];
            String[] idArray = idPhotos.Split(',');

            List<Order> orders = new List<Order>();
            for (int i = 0; i < idArray.Length; i++)
            {
                Order order = new Order();
                order.id = int.Parse(idArray[i]);
                order.order = i;
                orders.Add(order);
            }
            await this.repoPhoto.OrderPhotos(orders,token);

            return Json(true);
        }

        [HttpPost]
        public async Task<IActionResult> MovePhotos(int session)
        {
            String token = HttpContext.User.FindFirst(ClaimTypes.Role).Value;

            String idPhotos = Request.Form["idPhotos"];
            String[] idArray = idPhotos.Split(',');
            String oldSession = Request.Form["oldSession"];

            this.repository.CrearContenedor("s" + session.ToString());

            foreach (String id in idArray)
            {
                int idPhoto = int.Parse(id);
                PHOTO photo = await this.repoPhoto.GetPhotoById(idPhoto);
                String imageName = photo.Picture;
                await this.repository.MoverBlob("s" + oldSession.ToString(), imageName, "s" + session.ToString());
                String uri = await this.repository.GetUriBlob("s" + session.ToString(), imageName);
                await this.repoPhoto.MovePhotosSesion(idPhoto, session, uri, token);
            }
            return Json(true);
        }

        [HttpPost]
        public async Task<IActionResult> SetFavorite(int idPhoto)
        {
            String token = HttpContext.User.FindFirst(ClaimTypes.Role).Value;

            await this.repoPhoto.SetFavorite(idPhoto, token);
            return Json(true);
        }
        [HttpPost]
        public async Task<IActionResult> UndoFavorite(int idPhoto)
        {
            String token = HttpContext.User.FindFirst(ClaimTypes.Role).Value;
            await this.repoPhoto.UndoFavorite(idPhoto, token);
            return Json(true);
        }

        [HttpPost]
        public async Task<IActionResult> OrderFavorites()
        {
            String token = HttpContext.User.FindFirst(ClaimTypes.Role).Value;

            String idPhotos = Request.Form["idPhotos"];
            String[] idArray = idPhotos.Split(',');
            List<Order> orders = new List<Order>();
            for (int i = 0; i < idArray.Length; i++)
            {
                Order order = new Order();
                order.id = int.Parse(idArray[i]);
                order.order = i;
                orders.Add(order);
            }
            await this.repoPhoto.OrderFavorite(orders, token);
            return Json(true);
        }
    }
}