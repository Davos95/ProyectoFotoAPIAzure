using Microsoft.EntityFrameworkCore;
using ProyectoFotoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFotoCore.Data
{
    public interface IPictureManagerContext
    {
        DbSet<COMISION> Comisions { get; set; }
        DbSet<PHOTO> Photos { get; set; }
        DbSet<SESSION> Sessions { get; set; }
        DbSet<SESSION_WORKER> Session_Workers { get; set; }
        DbSet<USER> Users { get; set; }
        DbSet<WORK> Works { get; set; }
        DbSet<WORKER> Workers { get; set; }
        DbSet<Worker_Session_Complex> ComplexWorkers { get; set; }
        DbSet<SESSION_COMPLEX> SessionComplex { get; set; }


        #region Comisions

        List<COMISION> GetCOMISIONS();
        void InsertComision(String name, String description, String path, float price);
        void DeleteComision(int id);
        void ModifyComision(int id, String name, String image, String description, float price);
        void OrderComision(int id, int order);
        COMISION GetComisionByID(int id);

        #endregion

        #region Login
        USER GetUSER(String nick, String pwd);
        #endregion

        #region Partner
        List<WORKER> GetPartners();
        void InsertPartner(String name, String contact, String urlContact);
        void RemovePartner(int id);
        void UpdatePartner(int id, String name, String contact, String urlContact);
        #endregion


        #region Photo
        List<PHOTO> GetPhotos(int idSesion);
        void InsertPhoto(String name, int idSesion);
        void RemovePhoto(int idPhoto);
        void OrderPhoto(int idPhoto, int orderNumber);
        void MovePhotosSesion(int idPhoto, int idSesion);
        PHOTO GetPhotoById(int idPhoto);
        #endregion

        #region Sesion
        List<SESSION> GetSesions();
        void InsertSesion(String name, String description, DateTime date, int comision);
        void DeleteSesion(int id);
        SESSION GetSESIONID(int id);
        void AddPartnerWorkIntoSesion(int idSesion, int idPartner, int idWork);
        List<Worker_Session_Complex> GetPartnerWorkBySesion(int idSesion);
        void DeletePartnerWorkFromSesion(int idSesion, int idPartner, int idWork);
        void ModifySesion(int idSesion, String name, String desciption, DateTime date, int idComision);

        void SetImageSession(int idSesion, int idImage);

        List<SESSION_COMPLEX> GetSessionsComplex();
        SESSION_COMPLEX GetSessionComplexById(int idSession);
        #endregion

        #region Work
        List<WORK> GetWORKs();
        void InsertWork(String name);
        void DeleteWork(int id);
        #endregion

        #region Favorite
        List<PHOTO_COMPLEX> GetFavorites();
        void SetFavorite(int idPhoto);
        void UndoFavorite(int idPhoto);
        void OrderFavorite(int idPhoto, int orderFavorite);
        #endregion
    }
}
