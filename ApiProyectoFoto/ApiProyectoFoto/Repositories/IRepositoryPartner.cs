using ApiProyectoFoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProyectoFoto.Repositories
{
    public interface IRepositoryPartner
    {
        List<WORKER> GetPartners();
        void InsertPartner(String name, String contact, String urlContact);
        void RemovePartner(int id);
        void UpdatePartner(int id, String name, String contact, String urlContact);

    }
}
