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
    public class PartnerController : ControllerBase
    {
        IRepositoryPartner repo;
        public PartnerController(IRepositoryPartner repo)
        {
            this.repo = repo;
        }

        public List<WORKER> GetPartners()
        {
            return this.repo.GetPartners();
        }

        [HttpPost]
        [Route("[action]")]
        public void Insert(WORKER w)
        {
            this.repo.InsertPartner(w.Name, w.Contact, w.UrlContact);
        }

        [HttpPost]
        [Route("[action]")]
        public void Modify(WORKER w)
        {
            this.repo.UpdatePartner(w.Id, w.Name, w.Contact, w.UrlContact);
        }

        [HttpDelete]
        [Route("[action]")]
        public void Delete(int id)
        {
            this.repo.RemovePartner(id);
        }

        
    }
}