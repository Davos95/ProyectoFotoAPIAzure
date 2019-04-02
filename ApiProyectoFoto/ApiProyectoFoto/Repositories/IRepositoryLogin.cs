using ApiProyectoFoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProyectoFoto.Repositories
{
    public interface IRepositoryLogin
    {
        USER GetUser(String nick, String pwd);

    }
}
