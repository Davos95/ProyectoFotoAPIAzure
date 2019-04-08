using ApiProyectoFoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProyectoFoto.Repositories
{
    public interface IRepositorySesion
    {
        List<SESSION> GetSesions();
        SESSION GetSESIONID(int id);
        void InsertSesion(String name, String description, DateTime date, int comision);
        void ModifySesion(int idSesion, String name, String desciption, DateTime date, int idComision);
        void DeleteSesion(int id);


        List<Worker_Session_Complex> GetPartnerWorkBySesion(int idSesion);
        void AddPartnerWorkIntoSesion(int idSesion, int idPartner, int idWork);
        void DeletePartnerWorkFromSesion(int idSesion, int idPartner, int idWork);

        
        List<SESSION_COMPLEX> GetSessionsComplex();
        SESSION_COMPLEX GetSessionComplexById(int idSession);

        void SetImageSession(int idSession, int idImage);
    }
}
