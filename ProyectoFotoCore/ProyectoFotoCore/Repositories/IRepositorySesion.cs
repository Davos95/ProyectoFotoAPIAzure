
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

        Task InsertSesion(String name, String description, DateTime date, int comision, String token);
        Task ModifySesion(int idSesion, String name, String desciption, DateTime date, int idComision, String token);
        Task DeleteSesion(int id, String token);
        

        Task<List<Worker_Session_Complex>> GetPartnerWorkBySesion(int idSesion);
        Task AddPartnerWorkIntoSesion(int idSesion, int idPartner, int idWork, String token);
        Task DeletePartnerWorkFromSesion(int idSesion, int idPartner, int idWork, String token);


        Task<List<SESSION_COMPLEX>> GetSessionsComplex();
        Task<SESSION_COMPLEX> GetSessionComplexById(int idSession);
        Task SetImageSession(int idSession, int idImage, String token);
    }
}
