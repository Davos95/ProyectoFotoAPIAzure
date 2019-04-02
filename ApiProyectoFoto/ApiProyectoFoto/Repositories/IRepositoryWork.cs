using ApiProyectoFoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProyectoFoto.Repositories
{
    public interface IRepositoryWork
    {
        List<WORK> GetWORKs();
        void InsertWork(String name);
        void DeleteWork(int id);
    }
}
