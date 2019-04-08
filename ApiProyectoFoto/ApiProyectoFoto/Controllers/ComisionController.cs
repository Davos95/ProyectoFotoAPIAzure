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

        [HttpGet]
        [Route("[action]/{id}")]
        public COMISION Get(int id)
        {
            return this.repo.GetComisionByID(id);
        }

        [HttpPost]
        [Route("[action]")]
        public void Insert(COMISION com)
        {
            this.repo.InsertComision(com.Name, com.Description, float.Parse(com.Price.ToString()),com.UriAzure);
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public void Delete(int id)
        {
            this.repo.DeleteComision(id);
        }

        [HttpPost]
        [Route("[action]")]
        public void Modify(COMISION com)
        {
            this.repo.ModifyComision(com.Id, com.Name, com.Description, "", com.Name, float.Parse(com.Price.ToString()), com.UriAzure);
        }

        [HttpPost]
        [Route("[action]")]
        public void Order([FromBody] List<Order> Orders)
        {
            this.repo.OrderComision(Orders);
        }

    }
}