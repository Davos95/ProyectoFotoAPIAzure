using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFotoCore.Models;
using ProyectoFotoCore.Provider;
using ProyectoFotoCore.Repositories;
using ProyectoFotoCore.Tools;

namespace ProyectoFotoCore.Controllers
{
    public class ComisionController : Controller
    {
        PathProv prov;
        IRepositoryComision repo;
        RepositoryAzureBlob repoAzure;

        public ComisionController(IRepositoryComision repo, PathProv prov, RepositoryAzureBlob repoAzure)
        {
            this.repo = repo;
            this.prov = prov;
            this.repoAzure = repoAzure;
        }
        public async Task<IActionResult> Comision()
        {
            List<COMISION> comisions = await this.repo.GetCOMISIONS();
            return View(comisions);
        }

        [HttpPost]
        public async Task<IActionResult> Comision(String name, String description, IFormFile photo, float price, int? id, String option)
        {
            String path = prov.MapPath(Folders.Comision);

            if (option == "ADD")
            {
                if (photo != null && photo.Length > 0)
                {
                    this.repoAzure.CrearContenedor("comision");
                    await this.repoAzure.SubirBlob("comision", photo, name);
                    String uri = await this.repoAzure.GetUriBlob("comision", name);
                    await repo.InsertComision(name, description, "~/images/comision\\", photo, price, uri);
                }
            }
            else if (option == "UPDATE")
            {
                COMISION comision = await this.repo.GetComisionByID(id.Value);
                if (comision != null)
                {
                    await this.repoAzure.SubirBlob("comision", photo, name);
                    String uri = await this.repoAzure.GetUriBlob("comision", name);
                    await repo.ModifyComision(id.Value, name, description, "~/images/comision\\", "", price, uri);
                }

            }
            else if (option == "DELETE")
            {
                COMISION comision = await this.repo.GetComisionByID(id.Value);
                if (comision != null)
                {
                    await repo.DeleteComision(id.Value);
                    await this.repoAzure.EliminarBlob("comision", name);
                }
            }

            return RedirectToAction("Comision");
        }


        public void OrderComision(String[] order)
        {
            this.repo.OrderComision(order);
        }
    }
}