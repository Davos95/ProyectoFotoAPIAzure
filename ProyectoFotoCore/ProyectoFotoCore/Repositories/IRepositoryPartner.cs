using ProyectoFotoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFotoCore.Repositories
{
    public interface IRepositoryPartner
    {
        Task<List<WORKER>> GetPartners();
        Task InsertPartner(String name, String contact, String urlContact);
        Task RemovePartner(int id);
        Task UpdatePartner(int id, String name, String contact, String urlContact);

    }
}
