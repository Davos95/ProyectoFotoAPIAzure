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
        Task InsertPartner(String name, String contact, String urlContact, String token);
        Task RemovePartner(int id, String token);
        Task UpdatePartner(int id, String name, String contact, String urlContact, String token);

    }
}
