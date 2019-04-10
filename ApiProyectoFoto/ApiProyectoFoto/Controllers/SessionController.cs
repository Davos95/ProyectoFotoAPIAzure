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
    public class SessionController : ControllerBase
    {
        IRepositorySesion repo;
        public SessionController(IRepositorySesion repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<SESSION> GetSessions()
        {
            return this.repo.GetSesions();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public SESSION Get(int id)
        {
            return this.repo.GetSESIONID(id);
        }

        [HttpPost]
        [Authorize]
        [Route("[action]")]
        public void Insert(SESSION s)
        {
            this.repo.InsertSesion(s.Name, s.Description, s.DateSesion, s.IdComision);
        }

        [HttpPost]
        [Authorize]
        [Route("[action]")]
        public void Modify(SESSION s)
        {
            this.repo.ModifySesion(s.Id, s.Name, s.Description, s.DateSesion, s.IdComision);
        }

        [HttpDelete]
        [Authorize]
        [Route("[action]/{id}")]
        public void Delete(int id)
        {
            this.repo.DeleteSesion(id);
        }


        #region PartnerWork
        [HttpGet]
        [Route("[action]/{id}")]
        public List<Worker_Session_Complex> getPartnerWork(int id)
        {
            return this.repo.GetPartnerWorkBySesion(id);
        }

        [HttpPost]
        [Authorize]
        [Route("[action]")]
        public void addPartnerWork(SESSION_WORKER s)
        {
            this.repo.AddPartnerWorkIntoSesion(s.IdSession, s.IdWorker, s.IdWork);
        }

        [HttpPost]
        [Authorize]
        [Route("[action]")]
        public void deletePartnerWork(SESSION_WORKER s)
        {
            this.repo.DeletePartnerWorkFromSesion(s.IdSession, s.IdWorker, s.IdWork);
        }
        #endregion

        #region SessionComplex

        [HttpGet]
        [Route("[action]")]
        public List<SESSION_COMPLEX> GetComplex()
        {
            return this.repo.GetSessionsComplex();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public SESSION_COMPLEX GetComplexById(int id)
        {
            return this.repo.GetSessionComplexById(id);
        }

        [HttpPost]
        [Authorize]
        [Route("[action]")]
        public void SetImageSession(Order o)
        {
            this.repo.SetImageSession(o.id, o.order);
        }

        #endregion

    }
}