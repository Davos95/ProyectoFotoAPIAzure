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
        Task<List<COMISION>> GetCOMISIONS();
        Task InsertComision(String name, String description, String folder, IFormFile image, float price,String UriAzure);
        Task DeleteComision(int id);
        Task ModifyComision(int id, String name, String description, String folder, String image, float price, String UriAzure);
        Task OrderComision(String[] order);
        Task<COMISION> GetComisionByID(int id);
    }
}
