using Microsoft.AspNetCore.Http;
using ProyectoFotoCore.Data;
using ProyectoFotoCore.Models;
using ProyectoFotoCore.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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

namespace ProyectoFotoCore.Repositories
{
    public class RepositoryComision : IRepositoryComision
    {
        ApiConnect api;
        public RepositoryComision(ApiConnect api)
        {
            this.api = api;
        }

        public async Task<List<COMISION>> GetCOMISIONS()
        {
             List<COMISION> comisions = await this.api.CallApi<List<COMISION>>("api/Comision",null);
            return comisions;
        }

        public async Task<COMISION> GetComisionByID(int id)
        {
            var comision = await this.api.CallApi<COMISION>("api/Comision/Get/" + id, null);
            return comision;
        }

        public async Task InsertComision(String name, String description, String folder, IFormFile image, float price, String UriAzure)
        {
            COMISION c = new COMISION();
            c.Name = name;
            c.Description = description;
            c.Photo = name;
            c.Price = price;
            c.UriAzure = UriAzure;
            await this.api.CallApiPost(c, "api/Comision/Insert", null);
        }

        public async Task DeleteComision(int id)
        {
            COMISION comision = await GetComisionByID(id);
            if(comision != null)
            {
              await this.api.ApiDelete("api/Comision/Delete/" + id, null);
            }
        }

        public async Task ModifyComision(int id, String name, String description, String folder, String image, float price, String UriAzure)
        {
            COMISION c = new COMISION();
            c.Id = id;
            c.Name = name;
            c.Description = description;
            c.Price = price;
            c.UriAzure = UriAzure;
            await this.api.CallApiPost(c, "api/Comision/Modify", null);
        }

        public async Task OrderComision(String [] order)
        {
            List<Order> orders = new List<Order>();

            for (int i = 0; i < order.Length; i++)
            {
                Order ord = new Order();
                ord.id = int.Parse(order[i]);
                ord.order = i;
                orders.Add(ord);
            }
            await this.api.CallApiPost(orders, "api/Comision/Order", null);
        }
    }
}
