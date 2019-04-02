using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProyectoFoto.Models;
using ApiProyectoFoto.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProyectoFoto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComisionController : ControllerBase
    {
        IRepositoryComision repo;
        public ComisionController(IRepositoryComision repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<COMISION> GetComision()
        {
            return this.repo.GetCOMISIONS();
        }

        public COMISION Get(int id)
        {
            return this.repo.GetComisionByID(id);
        }

        [HttpPost]
        [Route("[action]")]
        public void Insert(COMISION com, IFormFile photo)
        {
            this.repo.InsertComision(com.Name, com.Description, "~/images/comision", photo, float.Parse(com.Price.ToString()));
        }

        [HttpPost]
        [Route("[action]")]
        public void Delete(int id, String folder)
        {
            this.repo.DeleteComision(id, folder);
        }

    }
}