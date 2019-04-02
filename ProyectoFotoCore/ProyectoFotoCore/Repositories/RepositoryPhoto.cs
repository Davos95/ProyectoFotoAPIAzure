using ProyectoFotoCore.Data;
using ProyectoFotoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region PROCEDURES
/*
 CREATE PROCEDURE GETPHOTOS
(@IDSESION INT)
AS
	SELECT * FROM PHOTO
	WHERE IDSESION = @IDSESION
	ORDER BY ORDERPHOTO ASC;
GO

CREATE PROCEDURE INSERTPHOTO
(@NAMEPHOTO TEXT, @IDSESION INT)
AS
	DECLARE @NUM INT
	SELECT @NUM = COUNT(*) FROM PHOTO WHERE IDSESION = @IDSESION
	INSERT INTO PHOTO VALUES(@NAMEPHOTO,@IDSESION,@NUM)
GO

CREATE PROCEDURE DELETEPHOTO
(@IDPHOTO INT)
AS
	DELETE FROM PHOTO
	WHERE ID = @IDPHOTO;
GO

CREATE PROCEDURE ORDERPHOTO
(@IDPHOTO INT, @NUMORDER INT)
AS
	UPDATE PHOTO SET ORDERPHOTO = @NUMORDER
	WHERE ID = @IDPHOTO;
GO

CREATE PROCEDURE MOVEPHOTOS
(@IDPHOTO INT, @IDSESION INT)
AS
	DECLARE @COUNT INT
	
	SELECT @COUNT = COUNT(*) 
	FROM PHOTO
	WHERE IDSESION = @IDSESION

	UPDATE PHOTO 
	SET IDSESION = @IDSESION,
	ORDERPHOTO = @COUNT
	WHERE ID = @IDPHOTO
	
GO


CREATE PROCEDURE GETFAVORITES
AS
	SELECT * FROM PHOTO
	WHERE FAVORITE = 1
	ORDER BY ORDERFAVORITE
GO

CREATE PROCEDURE SETFAVORITE 
(@IDPHOTO INT)
AS
	DECLARE @COUNT INT
	SELECT @COUNT = COUNT(*) FROM PHOTO WHERE FAVORITE = 1

	UPDATE PHOTO SET FAVORITE = 1, ORDERFAVORITE = @COUNT WHERE ID = @IDPHOTO
GO

CREATE PROCEDURE UNDOFAVORITE 
(@IDPHOTO INT)
AS
UPDATE PHOTO SET FAVORITE = 0 WHERE ID = @IDPHOTO
GO

CREATE PROCEDURE ORDERFAVORITE
(@IDPHOTO INT, @ORDER INT)
AS
UPDATE PHOTO SET ORDERFAVORITE = @ORDER WHERE ID = @IDPHOTO
GO



*/
#endregion

namespace ProyectoFotoCore.Repositories
{
    public class RepositoryPhoto : IRepositoryPhoto
    {
        IPictureManagerContext context;
        public RepositoryPhoto(IPictureManagerContext context)
        {
            this.context = context;
        }

       

        public PHOTO GetPhotoById(int idPhoto)
        {
            return this.context.GetPhotoById(idPhoto);
        }

        public List<PHOTO> GetPhotos(int idSesion)
        {
            return this.context.GetPhotos(idSesion);
        }

        public void InsertPhoto(string name, int idSesion)
        {
            this.context.InsertPhoto(name, idSesion);
        }

        public void MovePhotosSesion(int idPhoto, int idSesion)
        {
            this.context.MovePhotosSesion(idPhoto, idSesion);
        }

      

        public void OrderPhotos(int idPhoto, int orderNumber)
        {
            this.context.OrderPhoto(idPhoto, orderNumber);
        }


        public void RemovePhotos(int idPhoto)
        {
            this.context.RemovePhoto(idPhoto);
        }

        #region Favorites
        public List<PHOTO_COMPLEX> GetFavorites()
        {
            return this.context.GetFavorites();
        }

        public void SetFavorite(int idPhoto)
        {
            this.context.SetFavorite(idPhoto);
        }

        public void UndoFavorite(int idPhoto)
        {
            this.context.UndoFavorite(idPhoto);
        }

        public void OrderFavorite(int idPhoto, int orderFavorite)
        {
            this.context.OrderFavorite(idPhoto, orderFavorite);
        }

        #endregion
    }
}
