using System;
using System.Collections.Generic;
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

        public ComisionController(IRepositoryComision repo, PathProv prov)
        {
            this.repo = repo;
            this.prov = prov;
        }
        public IActionResult Comision()
        {
            List<COMISION> comisions = this.repo.GetCOMISIONS();
            return View(comisions);
        }

        [HttpPost]
        public IActionResult Comision(String name, String description, IFormFile photo, float price, int? id, String option)
        {
            String path = prov.MapPath(Folders.Comision);

            if (option == "ADD")
            {
                if (photo != null && photo.Length > 0)
                {
                    ToolImage.UploadImage(photo,path,name);
                    repo.InsertComision(name, description, "~/images/comision\\", photo, price);
                }
            }
            else if (option == "UPDATE")
            {
                COMISION comision = this.repo.GetComisionByID(id.Value);
                if (comision != null)
                {
                    String image = null;
                    if (photo != null)
                    {
                        String photoRemove = comision.Photo.Split('\\')[1];
                        ToolImage.RemoveImage(photoRemove, path);
                        ToolImage.UploadImage(photo, path, name);

                        String type = photo.ContentType.Split('/')[1];
                        image = name + "." + type;
                    }

                    repo.ModifyComision(id.Value, name, description, "~/images/comision\\", image, price);
                }

            }
            else if (option == "DELETE")
            {
                COMISION comision = this.repo.GetComisionByID(id.Value);
                if (comision != null)
                {
                    repo.DeleteComision(id.Value, path);
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