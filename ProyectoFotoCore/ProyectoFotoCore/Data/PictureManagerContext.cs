using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ProyectoFotoCore.Models;

namespace ProyectoFotoCore.Data
{
    public class PictureManagerContext: DbContext, IPictureManagerContext
    {
        public PictureManagerContext(DbContextOptions options) : base(options) { }

        public DbSet<COMISION> Comisions { get; set; }
        public DbSet<PHOTO> Photos { get; set; }
        public DbSet<SESSION> Sessions { get; set; }
        public DbSet<SESSION_WORKER> Session_Workers { get; set; }
        public DbSet<USER> Users { get; set; }
        public DbSet<WORK> Works { get; set; }
        public DbSet<WORKER> Workers { get; set; }
        public DbSet<Worker_Session_Complex> ComplexWorkers { get; set; }
        public DbSet<PHOTO_COMPLEX> ComplexPhoto { get; set; }
        public DbSet<SESSION_COMPLEX> SessionComplex { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SESSION_WORKER>().HasKey(c => new { c.IdSession, c.IdWork });
            modelBuilder.Entity<PHOTO>().HasKey(c => new { c.Id, c.Picture });
        }


        #region Comisions
        public List<COMISION> GetCOMISIONS()
        {
            String sql = "GETCOMISIONS";

            return this.Comisions.FromSql(sql).ToList();
        }

        public void InsertComision(string name, string description, string path, float price)
        {
            String sql = "INSERTCOMISION @NAME,@DESCRIPTION,@PATH,@PRICE";
            SqlParameter pamName = new SqlParameter("@NAME", name);
            SqlParameter pamDescription = new SqlParameter("@DESCRIPTION", description);
            SqlParameter pamPath = new SqlParameter("@PATH", path);
            SqlParameter pamPrice = new SqlParameter("@PRICE", price);

            this.Database.ExecuteSqlCommand(sql, pamName, pamDescription, pamPath, pamPrice);
        }

        public void DeleteComision(int id)
        {
            String sql = "DELETECOMISION @ID";
            SqlParameter pamId = new SqlParameter("@ID", id);
            this.Database.ExecuteSqlCommand(sql, pamId);
        }

        public void ModifyComision(int id, string name, string image, string description, float price)
        {
            String sql = "MODIFYSESSION @ID,@NAME,@PHOTO,@DESCRIPTION,@PRICE";
            SqlParameter pamId = new SqlParameter("@ID", id);
            SqlParameter pamName = new SqlParameter("@NAME", name);
            SqlParameter pamPhoto = new SqlParameter("@PHOTO", image);
            SqlParameter pamDescription = new SqlParameter("@DESCRIPTION", description);
            SqlParameter pamPrice = new SqlParameter("@PRICE", price);

            this.Database.ExecuteSqlCommand(sql, pamId, pamName, pamPhoto, pamDescription, pamPrice);
        }

        public void OrderComision(int id, int order)
        {
            String sql = "MODIFYORDERCOMISION @ID,@ORDER";
            SqlParameter pamId = new SqlParameter("@ID", id);
            SqlParameter pamOrder = new SqlParameter("@ORDER", order);

            this.Database.ExecuteSqlCommand(sql, pamId, pamOrder);
        }

        public COMISION GetComisionByID(int id)
        {
            return this.GetCOMISIONS().Where(x => x.Id == id).FirstOrDefault();
        }



        #endregion

        #region Login
        public USER GetUSER(string nick, string pwd)
        {
            String sql = "GETUSER @NICK,@PWD";
            SqlParameter pamNick = new SqlParameter("@NICK", nick);
            SqlParameter pamPWD = new SqlParameter("@PWD", pwd);
            return this.Users.FromSql(sql, pamNick, pamPWD).FirstOrDefault();
        }

        #endregion

        #region Partner
        public List<WORKER> GetPartners()
        {
            String sql = "MOSTRARPARTICIPANTES";
            return this.Workers.FromSql(sql).ToList();
        }

        public void InsertPartner(string name, string contact, string urlContact)
        {
            String sql = "ADDPARTICIPANTE @NAME,@CONTACT,@URLCONTACT";
            SqlParameter pamName = new SqlParameter("@NAME",name);
            SqlParameter pamContact = new SqlParameter("@CONTACT", contact);
            SqlParameter pamUrlContact = new SqlParameter("@URLCONTACT", urlContact);

            this.Database.ExecuteSqlCommand(sql, pamName, pamContact, pamUrlContact);
        }

        public void RemovePartner(int id)
        {
            String sql = "DELETEPARTICIPANTE @ID";
            SqlParameter pamId = new SqlParameter("@ID", id);

            this.Database.ExecuteSqlCommand(sql, pamId);
        }

        public void UpdatePartner(int id, string name, string contact, string urlContact)
        {
            String sql = "UPDATEPARTICIPANTE @ID,@NAME,@CONTACT,@URLCONTACT";
            SqlParameter pamId = new SqlParameter("@ID", id);
            SqlParameter pamName = new SqlParameter("@NAME", name);
            SqlParameter pamContact = new SqlParameter("@CONTACT", contact);
            SqlParameter pamUrlContact = new SqlParameter("@URLCONTACT", urlContact);

            this.Database.ExecuteSqlCommand(sql, pamId, pamName, pamContact, pamUrlContact);
        }

        #endregion

        #region Photo
        public List<PHOTO> GetPhotos(int idSesion)
        {
            String sql = "GETPHOTOS @IDSESION";
            SqlParameter pamId = new SqlParameter("@IDSESION", idSesion);

            return this.Photos.FromSql(sql, pamId).ToList();
        }

        public void InsertPhoto(string name, int idSesion)
        {
            String sql = "INSERTPHOTO @NAMEPHOTO,@IDSESION";
            SqlParameter pamName = new SqlParameter("@NAMEPHOTO", name);
            SqlParameter pamId = new SqlParameter("@IDSESION", idSesion);

            this.Database.ExecuteSqlCommand(sql, pamName, pamId);
        }

        public void RemovePhoto(int idPhoto)
        {
            String sql = "DELETEPHOTO @IDPHOTO";
            SqlParameter pamId = new SqlParameter("@IDPHOTO", idPhoto);

            this.Database.ExecuteSqlCommand(sql, pamId);
        }

        public void OrderPhoto(int idPhoto, int orderNumber)
        {
            String sql = "ORDERPHOTO @IDPHOTO,@NUMORDER";
            SqlParameter pamId = new SqlParameter("@IDPHOTO", idPhoto);
            SqlParameter pamOrder = new SqlParameter("@NUMORDER", orderNumber);

            this.Database.ExecuteSqlCommand(sql, pamId, pamOrder);
        }

        public void MovePhotosSesion(int idPhoto, int idSesion)
        {
            String sql = "MOVEPHOTOS @IDPHOTO,@IDSESION";
            SqlParameter pamIdPhoto = new SqlParameter("@IDPHOTO", idPhoto);
            SqlParameter pamIdSession = new SqlParameter("@IDSESION", idSesion);

            this.Database.ExecuteSqlCommand(sql, pamIdPhoto, pamIdSession);
        }

        public PHOTO GetPhotoById(int idPhoto)
        {
            String sql = "GETPHOTOBYID @IDPHOTO";
            SqlParameter pamId = new SqlParameter("@IDPHOTO", idPhoto);
            return this.Photos.FromSql(sql, pamId).FirstOrDefault();
        }


        #endregion

        #region Session
        public List<SESSION> GetSesions()
        {
            String sql = "GETSESION";
            return this.Sessions.FromSql(sql).ToList();
        }

        public void InsertSesion(string name, string description, DateTime date, int comision)
        {
            String sql = "INSERTSESION @NAME,@DESCRIPTION,@DATE,@IDCOMISION";
            SqlParameter pamName = new SqlParameter("@NAME", name);
            SqlParameter pamDescription = new SqlParameter("@DESCRIPTION", description);
            SqlParameter pamDate = new SqlParameter("DATE", date);
            SqlParameter pamComision = new SqlParameter("@IDCOMISION", comision);

            this.Database.ExecuteSqlCommand(sql, pamName, pamDescription, pamDate, pamComision);
        }

        public void DeleteSesion(int id)
        {
            String sql = "DELETESESION @ID";
            SqlParameter pamId = new SqlParameter("@ID", id);

            this.Database.ExecuteSqlCommand(sql, pamId);
        }

        public SESSION GetSESIONID(int id)
        {
            String sql = "GETSESIONID @ID";
            SqlParameter pamId = new SqlParameter("@ID", id);

            return this.Sessions.FromSql(sql, pamId).FirstOrDefault();
        }

        public void AddPartnerWorkIntoSesion(int idSesion, int idPartner, int idWork)
        {
            String sql = "ADDPARTNERWORKINTOSESION @IDSESION,@IDPARTER,@IDWORK";
            SqlParameter pamIdSession = new SqlParameter("@IDSESION", idSesion);
            SqlParameter pamIdPartner = new SqlParameter("@IDPARTER", idPartner);
            SqlParameter pamIdWork = new SqlParameter("@IDWORK", idWork);

            this.Database.ExecuteSqlCommand(sql, pamIdSession, pamIdPartner, pamIdWork);
        }

        public List<Worker_Session_Complex> GetPartnerWorkBySesion(int idSesion)
        {
            String sql = "GETPARTNERWORKBYSESION @ID";
            SqlParameter pamId = new SqlParameter("@ID", idSesion);
            return this.ComplexWorkers.FromSql(sql, pamId).ToList();
        }

        public void DeletePartnerWorkFromSesion(int idSesion, int idPartner, int idWork)
        {
            String sql = "DELETEPARTERWORKFROMSESION @ID,@IDPARTNER,@IDWORK";
            SqlParameter pamIdSesion = new SqlParameter("@ID", idSesion);
            SqlParameter pamIdPartner = new SqlParameter("@IDPARTNER", idPartner);
            SqlParameter pamIdWork = new SqlParameter("@IDWORK", idWork);

            this.Database.ExecuteSqlCommand(sql, pamIdSesion, pamIdPartner, pamIdWork);
        }

        public void ModifySesion(int idSesion, string name, string desciption, DateTime date, int idComision)
        {
            String sql = "MODIFYSESION @ID,@NAME,@DESCRIPTION,@DATESESION,@IDCOMISION";
            SqlParameter pamIdSesion = new SqlParameter("@ID", idSesion);
            SqlParameter pamName = new SqlParameter("@NAME", name);
            SqlParameter pamDescription = new SqlParameter("@DESCRIPTION", desciption);
            SqlParameter pamDate = new SqlParameter("@DATESESION", date);
            SqlParameter pamComision = new SqlParameter("@IDCOMISION", idComision);

            this.Database.ExecuteSqlCommand(sql, pamIdSesion, pamName, pamDescription, pamDate, pamComision);
        }

        public void SetImageSession(int idSession, int idImage)
        {
            String sql = "SETIMAGESESSION @IDSESSION,@IDPHOTO";
            SqlParameter pamIdSession = new SqlParameter("@IDSESSION", idSession);
            SqlParameter pamIdImage = new SqlParameter("@IDPHOTO", idImage);
            this.Database.ExecuteSqlCommand(sql, pamIdSession, pamIdImage);
        }

        public List<SESSION_COMPLEX> GetSessionsComplex() {
            String sql = "GETCOMPLEXSESION";
            return this.SessionComplex.FromSql(sql).ToList();
        }

        public SESSION_COMPLEX GetSessionComplexById(int idSession)
        {
            String sql = "GETCOMPLEXSESIONBYID @ID";
            SqlParameter pamIdSession = new SqlParameter("@ID", idSession);
            return this.SessionComplex.FromSql(sql, pamIdSession).SingleOrDefault();
        }

        #endregion


        #region Work
        public List<WORK> GetWORKs()
        {
            String sql = "MOSTRARTRABAJOS";

            return this.Works.FromSql(sql).ToList();
        }

        public void InsertWork(string name)
        {
            String sql = "ADDTRABAJO @NAME";
            SqlParameter pamName = new SqlParameter("@NAME", name);

            this.Database.ExecuteSqlCommand(sql, pamName);
        }

        public void DeleteWork(int id)
        {
            String sql = "DELETETRABAJO @ID";
            SqlParameter pamId = new SqlParameter("@ID", id);

            this.Database.ExecuteSqlCommand(sql, pamId);
        }


        #endregion

        #region Favorite
        public List<PHOTO_COMPLEX> GetFavorites()
        {
            String sql = "GETFAVORITES";
            return this.ComplexPhoto.FromSql(sql).ToList();
        }

        public void SetFavorite(int idPhoto)
        {
            String sql = "SETFAVORITE @IDPHOTO";
            SqlParameter pamId = new SqlParameter("@IDPHOTO", idPhoto);
            this.Database.ExecuteSqlCommand(sql, pamId);
        }

        public void UndoFavorite(int idPhoto)
        {
            String sql = "UNDOFAVORITE @IDPHOTO";
            SqlParameter pamId = new SqlParameter("@IDPHOTO", idPhoto);
            this.Database.ExecuteSqlCommand(sql, pamId);
        }

        public void OrderFavorite(int idPhoto, int orderFavorite)
        {
            String sql = "ORDERFAVORITE @IDPHOTO,@ORDERFAVORITE";
            SqlParameter pamId = new SqlParameter("@IDPHOTO", idPhoto);
            SqlParameter pamOrder = new SqlParameter("@ORDERFAVORITE", orderFavorite);
            this.Database.ExecuteSqlCommand(sql, pamId,pamOrder);
        }

       


        #endregion
    }
}
