using ApiProyectoFoto.Data;
using ApiProyectoFoto.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

#region PROCEDURES
/*
 CREATE PROCEDURE INSERTCOMISION
(@NAME NVARCHAR(25), @DESCRIPTION TEXT, @PATH TEXT, @PRICE FLOAT)
AS
	DECLARE @ORDERCOMISION INT

	SELECT @ORDERCOMISION = COUNT(*) FROM COMISION

	SET @ORDERCOMISION = @ORDERCOMISION + 1

	INSERT INTO COMISION VALUES(@NAME,@DESCRIPTION, @ORDERCOMISION,@PRICE,@PATH)

GO

CREATE PROCEDURE GETCOMISIONS
AS
	SELECT * 
	FROM COMISION
	order by ORDERCOMISION;
GO 

CREATE PROCEDURE DELETECOMISION
(@ID INT)
AS
	DELETE FROM COMISION
	WHERE ID = @ID;
GO

    CREATE PROCEDURE MODIFYSESSION
(@ID INT, @NAME nvarchar(25), @PHOTO text, @DESCRIPTION TEXT, @PRICE float)
AS
	IF(@PHOTO IS NULL)
	BEGIN
		UPDATE COMISION
		SET NAME = @NAME,
		DESCRIPTION = @DESCRIPTION,
		PRICE = @PRICE
		WHERE ID = @ID;
	END
	ELSE
	BEGIN
		UPDATE COMISION
			SET NAME = @NAME,
			PHOTO = @PHOTO,
			DESCRIPTION = @DESCRIPTION,
			PRICE = @PRICE
			WHERE ID = @ID;
	END
GO

CREATE PROCEDURE MODIFYORDERCOMISION
(@ID INT, @ORDER INT)
AS
	UPDATE COMISION 
	SET ORDERCOMISION = @ORDER 
	WHERE ID = @ID;
GO

*/
#endregion

namespace ApiProyectoFoto.Repositories
{
    public class RepositoryComision : IRepositoryComision
    {
        IPictureManagerContext context;
        public RepositoryComision(IPictureManagerContext context)
        {
            this.context = context;
        }

        public List<COMISION> GetCOMISIONS()
        {
            var comisions = this.context.GetCOMISIONS();
            return comisions;
        }

        public COMISION GetComisionByID(int id)
        {
            var comision = this.context.GetComisionByID(id);
            return comision;
        }

        public void InsertComision(String name, String description, float price, String UriAzure)
        {
            context.InsertComision(name, description, "", price, UriAzure);
        }

        public void DeleteComision(int id)
        {
            COMISION comision = GetComisionByID(id);
            this.context.DeleteComision(id);
        }

        public void ModifyComision(int id, String name, String description, String folder, String image, float price, String UriAzure)
        {
            if (image != null)
            {
                image = folder + image;
            }
            this.context.ModifyComision(id, name, image, description, price, UriAzure);
        }

        public void OrderComision(List<Order>orders)
        {
            foreach (Order value in orders)
            {
                this.context.OrderComision(value.id, value.order);
            }
        }
    }
}
