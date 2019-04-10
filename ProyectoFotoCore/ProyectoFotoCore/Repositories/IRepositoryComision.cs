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
        Task InsertComision(String name, String description, String folder, IFormFile image, float price,String UriAzure, String token);
        Task DeleteComision(int id, String token);
        Task ModifyComision(int id, String name, String description, String folder, String image, float price, String UriAzure, String token);
        Task OrderComision(String[] order, String token);
        Task<COMISION> GetComisionByID(int id);
    }
}
