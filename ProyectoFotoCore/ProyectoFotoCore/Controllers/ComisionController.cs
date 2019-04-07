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
        public IActionResult Comision()
        {
            List<COMISION> comisions = this.repo.GetCOMISIONS();
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
                    repo.InsertComision(name, description, "~/images/comision\\", photo, price, uri);
                }
            }
            else if (option == "UPDATE")
            {
                COMISION comision = this.repo.GetComisionByID(id.Value);
                if (comision != null)
                {
                    await this.repoAzure.SubirBlob("comision", photo, name);
                    String uri = await this.repoAzure.GetUriBlob("comision", name);
                    repo.ModifyComision(id.Value, name, description, "~/images/comision\\", "", price, uri);
                }

            }
            else if (option == "DELETE")
            {
                COMISION comision = this.repo.GetComisionByID(id.Value);
                if (comision != null)
                {
                    repo.DeleteComision(id.Value, path);
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