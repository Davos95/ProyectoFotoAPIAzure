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
    public class WorkController : ControllerBase
    {
        IRepositoryWork repo;
        public WorkController(IRepositoryWork repo)
        {
            this.repo = repo;
        }

        public List<WORK> GetWorks()
        {
            return this.repo.GetWORKs();
        }

        [HttpPost]
        [Route("[action]")]
        public void Insert(String name)
        {
            this.repo.InsertWork(name);
        }

        [HttpPost]
        [Route("[action]")]
        public void Delete(int id)
        {
            this.repo.DeleteWork(id);
        }
    }

}