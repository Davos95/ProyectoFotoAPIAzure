
using ProyectoFotoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFotoCore.Repositories
{
    public interface IRepositorySesion
    {
        Task<List<SESSION>> GetSesions();
        Task<SESSION> GetSESIONID(int id);

        Task InsertSesion(String name, String description, DateTime date, int comision);
        Task ModifySesion(int idSesion, String name, String desciption, DateTime date, int idComision);
        Task DeleteSesion(int id);
        

        Task<List<Worker_Session_Complex>> GetPartnerWorkBySesion(int idSesion);
        Task AddPartnerWorkIntoSesion(int idSesion, int idPartner, int idWork);
        Task DeletePartnerWorkFromSesion(int idSesion, int idPartner, int idWork);


        Task<List<SESSION_COMPLEX>> GetSessionsComplex();
        Task<SESSION_COMPLEX> GetSessionComplexById(int idSession);
        Task SetImageSession(int idSession, int idImage);
    }
}
