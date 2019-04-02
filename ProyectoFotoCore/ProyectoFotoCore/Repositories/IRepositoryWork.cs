
using ProyectoFotoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFotoCore.Repositories
{
    public interface IRepositoryWork
    {
        List<WORK> GetWORKs();
        void InsertWork(String name);
        void DeleteWork(int id);
    }
}
