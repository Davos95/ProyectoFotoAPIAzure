using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProyectoFoto.Models;
using ApiProyectoFoto.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProyectoFoto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        IRepositoryPhoto repo;
        public PhotoController(IRepositoryPhoto repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public List<PHOTO> GetPhotos(int id)
        {
            return this.repo.GetPhotos(id);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public PHOTO GetPhotoById(int id)
        {
            return this.repo.GetPhotoById(id);
        }

        [HttpPost]
        [Authorize]
        [Route("[action]")]
        public void Insert(PHOTO p)
        {
            this.repo.InsertPhoto(p.Picture, p.IdSession, p.UriAzure);
        }

        [HttpPost]
        [Authorize]
        [Route("[action]")]
        public void Move(PHOTO p)
        {
            this.repo.MovePhotosSesion(p.Id, p.IdSession, p.UriAzure);
        }

        [HttpPost]
        [Authorize]
        [Route("[action]")]
        public void Order([FromBody] List<Order> orders)
        {
            foreach (Order o in orders)
            {
                this.repo.OrderPhotos(o.id, o.order);
            }
            
        }

        [HttpDelete]
        [Authorize]
        [Route("[action]/{id}")]
        public void Delete(int id)
        {
            this.repo.RemovePhotos(id);
        }

        [HttpGet]
        [Route("[action]")]
        public List<PHOTO_COMPLEX> Favorites()
        {
            return this.repo.GetFavorites();
        }

        [HttpPost]
        [Authorize]
        [Route("[action]")]
        public void SetFavorite(Order o)
        {
            this.repo.SetFavorite(o.id);
        }

        [HttpPost]
        [Authorize]
        [Route("[action]")]
        public void UndoFavorite(Order o)
        {
            this.repo.UndoFavorite(o.id);
        }

        [HttpPost]
        [Authorize]
        [Route("[action]")]
        public void OrderFavorite([FromBody] List<Order> orders)
        {
            foreach (Order o in orders)
            {
                this.repo.OrderFavorite(o.id, o.order);
            }
        }


    }
}