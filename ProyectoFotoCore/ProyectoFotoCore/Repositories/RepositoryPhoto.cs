using ProyectoFotoCore.Data;
using ProyectoFotoCore.Models;
using ProyectoFotoCore.Tools;
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
        ApiConnect api;
        public RepositoryPhoto(ApiConnect api)
        {
            this.api = api;
        }

       

        public async Task<PHOTO> GetPhotoById(int idPhoto)
        {
            return await this.api.CallApi<PHOTO>("api/Photo/GetPhotoById/" + idPhoto, null);
        }

        public async Task<List<PHOTO>> GetPhotos(int idSesion)
        {
            return await this.api.CallApi<List<PHOTO>>("api/Photo/GetPhotos/" + idSesion, null);
        }

        public async Task InsertPhoto(string name, int idSesion, String UriAzure)
        {
            PHOTO p = new PHOTO();
            p.Picture = name;
            p.IdSession = idSesion;
            p.UriAzure = UriAzure;

            await this.api.CallApiPost(p, "api/Photo/Insert", null);
        }

        public async Task MovePhotosSesion(int idPhoto, int idSesion,String UriAzure)
        {
            PHOTO p = new PHOTO();
            p.Id = idPhoto;
            p.IdSession = idSesion;
            p.UriAzure = UriAzure;
            await this.api.CallApiPost(p, "api/Photo/Move", null);
        }

        public async Task OrderPhotos(List<Order> orders)
        {
            await this.api.CallApiPost(orders, "api/Photo/Order", null);
        }


        public async Task RemovePhotos(int idPhoto)
        {
            await this.api.ApiDelete("api/Photo/Delete/" + idPhoto, null);
        }

        #region Favorites
        public async Task<List<PHOTO_COMPLEX>> GetFavorites()
        {
            return await this.api.CallApi<List<PHOTO_COMPLEX>>("api/Photo/Favorites", null);
        }

        public async Task SetFavorite(int idPhoto)
        {
            Order order = new Order();
            order.id = idPhoto;
            await this.api.CallApiPost(order, "api/Photo/SetFavorite", null);
        }

        public async Task UndoFavorite(int idPhoto)
        {
            Order order = new Order();
            order.id = idPhoto;
            await this.api.CallApiPost(order, "api/Photo/UndoFavorite", null);
        }

        public async Task OrderFavorite(List<Order> orders)
        {
            await this.api.CallApiPost(orders, "api/Photo/OrderFavorite", null);
        }

        #endregion
    }
}
