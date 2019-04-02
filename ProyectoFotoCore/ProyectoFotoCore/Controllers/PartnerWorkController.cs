using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoFotoCore.Filters;
using ProyectoFotoCore.Models;
using ProyectoFotoCore.Repositories;

namespace ProyectoFotoCore.Controllers
{
    [AuthorizedUser]
    public class PartnerWorkController : Controller
    {
        IRepositoryPartner repoP;
        IRepositoryWork repoW;
        public PartnerWorkController(IRepositoryPartner repoP, IRepositoryWork repoW)
        {
            this.repoP = repoP;
            this.repoW = repoW;
        }

        //GET: PARTNERS
        public IActionResult Partners()
        {
            List<WORKER> p = this.repoP.GetPartners();
            return View(p);
        }

        //POST: Partners
        [HttpPost]
        public IActionResult Partners(String name, String contact, String urlContact, int option, int? id)
        {
            if (option == 1)
            {
                this.repoP.InsertPartner(name, contact, urlContact);
            }
            else
            if (option == 2)
            {
                this.repoP.UpdatePartner(id.Value, name, contact, urlContact);
            }

            List<WORKER> p = this.repoP.GetPartners();
            return View(p);
        }

        public IActionResult DeletePartner(int id)
        {
            this.repoP.RemovePartner(id);
            return RedirectToAction("Partners");
        }

        //GET: WORKS
        public IActionResult Works()
        {
            List<WORK> works = this.repoW.GetWORKs();
            return View(works);
        }

        //POST: WORKS
        [HttpPost]
        public ActionResult Works(String work, int option, int? id)
        {
            if (option == 0)
            {
                this.repoW.InsertWork(work);
            }

            List<WORK> works = this.repoW.GetWORKs();
            return View(works);
        }

        public IActionResult DeleteWork(int id)
        {
            this.repoW.DeleteWork(id);

            return RedirectToAction("Works");
        }
    }
}