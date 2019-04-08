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
        public async Task<IActionResult> Partners()
        {
            List<WORKER> p = await this.repoP.GetPartners();
            return View(p);
        }

        //POST: Partners
        [HttpPost]
        public async Task<IActionResult> Partners(String name, String contact, String urlContact, int option, int? id)
        {
            if (option == 1)
            {
                await this.repoP.InsertPartner(name, contact, urlContact);
            }
            else
            if (option == 2)
            {
                await this.repoP.UpdatePartner(id.Value, name, contact, urlContact);
            }

            List<WORKER> p = await this.repoP.GetPartners();
            return View(p);
        }

        public async Task<IActionResult> DeletePartner(int id)
        {
            await this.repoP.RemovePartner(id);
            return RedirectToAction("Partners");
        }

        //GET: WORKS
        public async Task<IActionResult> Works()
        {
            List<WORK> works = await this.repoW.GetWORKs();
            return View(works);
        }

        //POST: WORKS
        [HttpPost]
        public async Task<ActionResult> Works(String work, int option, int? id)
        {
            if (option == 0)
            {
                await this.repoW.InsertWork(work);
            }

            List<WORK> works = await this.repoW.GetWORKs();
            return View(works);
        }

        public async Task<IActionResult> DeleteWork(int id)
        {
            await this.repoW.DeleteWork(id);

            return RedirectToAction("Works");
        }
    }
}