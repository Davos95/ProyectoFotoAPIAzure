using Microsoft.AspNetCore.Http;
using ProyectoFotoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ProyectoFotoCore.Repositories
{
    public interface IRepositoryComision
    {
        List<COMISION> GetCOMISIONS();
        void InsertComision(String name, String description, String folder, IFormFile image, float price,String UriAzure);
        void DeleteComision(int id, String folder);
        void ModifyComision(int id, String name, String description, String folder, String image, float price, String UriAzure);
        void OrderComision(String[] order);
        COMISION GetComisionByID(int id);
    }
}
