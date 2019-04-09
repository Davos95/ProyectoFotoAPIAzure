
using ProyectoFotoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFotoCore.Repositories
{
    public interface IRepositoryLogin
    {
        Task<USER> GetUser(String token);
        Task<String> GetToken(String nick, String pwd);
    }
}
