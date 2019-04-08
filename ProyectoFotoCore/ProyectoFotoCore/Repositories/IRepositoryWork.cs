
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
        Task<List<WORK>> GetWORKs();
        Task InsertWork(String name);
        Task DeleteWork(int id);
    }
}
