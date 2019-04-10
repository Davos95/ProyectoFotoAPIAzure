

using ProyectoFotoCore.Models;
using ProyectoFotoCore.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region PROCEDURES
/*
CREATE PROCEDURE INSERTSESION
(@NAME NVARCHAR(25), @DESCRIPTION TEXT, @DATE DATE, @IDCOMISION INT)
AS
	INSERT INTO SESION VALUES(@NAME,@DESCRIPTION,NULL,@DATE,@IDCOMISION)
GO

CREATE PROCEDURE GETSESION
AS
SELECT * FROM SESION;
GO

CREATE PROCEDURE DELETESESION
(@ID INT)
AS
DELETE FROM SESION WHERE ID = @ID;
GO

CREATE PROCEDURE GETSESIONID
(@ID INT)
AS
SELECT * FROM SESION WHERE ID = @ID;
GO

CREATE PROCEDURE GETPARTNERWORKBYSESION
(@ID INT)
AS
	SELECT sw.IDWORKER as IDPARTNER, p.NAME as PARTNER, sw.IDWORK as IDWORK, w.NAME as WORK
FROM SESION_WORKER sw
INNER JOIN SESION s
on s.ID =  sw.IDSESION
INNER JOIN WORK w
on w.ID = sw.IDWORK
INNER JOIN WORKER p
ON sw.IDWORKER = p.ID
WHERE s.ID = @ID;

GO

CREATE PROCEDURE ADDPARTNERWORKINTOSESION
(@IDSESION INT, @IDPARTER INT, @IDWORK INT)
AS
	INSERT INTO SESION_WORKER VALUES (@IDSESION,@IDPARTER,@IDWORK)
	
GO

CREATE PROCEDURE DELETEPARTERWORKFROMSESION
(@ID INT, @IDPARTNER INT, @IDWORK INT)
AS
DELETE FROM SESION_WORKER WHERE IDSESION = @ID AND IDWORKER = @IDPARTNER AND IDWORK = @IDWORK;
GO

CREATE PROCEDURE MODIFYSESION
(@ID INT, @NAME NVARCHAR(250), @DESCRIPTION TEXT, @DATESESION DATE, @IDCOMISION INT)
AS
UPDATE SESION 
SET NAME = @NAME, 
DESCRIPTION = @DESCRIPTION, 
DATESESION = @DATESESION, 
IDCOMISION = @IDCOMISION
WHERE ID = @ID
GO
*/
#endregion
namespace ProyectoFotoCore.Repositories
{
    public class RepositorySesion : IRepositorySesion
    {
        ApiConnect api;
        public RepositorySesion(ApiConnect api)
        {
            this.api = api;
        }

        public async Task<List<SESSION>> GetSesions()
        {
            var sesion = await this.api.CallApi<List<SESSION>>("api/Session",null);
            return sesion.ToList();
        }

        public async Task<SESSION> GetSESIONID(int id)
        {
            SESSION sesion = await this.api.CallApi<SESSION>("api/Session/Get/"+id,null);
            return sesion;
        }

        public async Task InsertSesion(String name, String description, DateTime date, int comision, String token)
        {
            SESSION s = new SESSION();
            s.Name = name;
            s.Description = description;
            s.DateSesion = date;
            s.IdComision = comision;
            await this.api.CallApiPost(s, "api/Session/Insert", token);
        }

        public async Task ModifySesion(int idSesion, String name, String desciption, DateTime date, int idComision, String token)
        {
            SESSION s = new SESSION();
            s.Id = idSesion;
            s.Name = name;
            s.Description = desciption;
            s.DateSesion = date;
            s.IdComision = idComision;
            await this.api.CallApiPost(s, "api/Session/Modify", token);
        }

        public async Task DeleteSesion(int id, String token)
        {
            await this.api.ApiDelete("api/Session/Delete/" + id, token);
        }




        #region EDIT SESION

        public async Task<List<Worker_Session_Complex>> GetPartnerWorkBySesion(int idSesion)
        {
            return await this.api.CallApi<List<Worker_Session_Complex>>("api/Session/getPartnerWork/"+idSesion, null);
        }

        public async Task AddPartnerWorkIntoSesion(int idSesion, int idPartner, int idWork, String token)
        {
            SESSION_WORKER sw = new SESSION_WORKER();
            sw.IdSession = idSesion;
            sw.IdWorker = idPartner;
            sw.IdWork = idWork;
            await this.api.CallApiPost(sw, "api/Session/addPartnerWork", token);
        }

        public async Task DeletePartnerWorkFromSesion(int idSesion, int idPartner, int idWork, String token)
        {
            SESSION_WORKER sw = new SESSION_WORKER();
            sw.IdSession = idSesion;
            sw.IdWorker = idPartner;
            sw.IdWork = idWork;
            await this.api.CallApiPost(sw, "api/Session/deletePartnerWork", token);
        }

        #endregion

        public async Task<List<SESSION_COMPLEX>> GetSessionsComplex()
        {
            return await this.api.CallApi<List<SESSION_COMPLEX>>("api/Session/GetComplex", null);
        }

        public async Task<SESSION_COMPLEX> GetSessionComplexById(int idSession)
        {
            return await this.api.CallApi<SESSION_COMPLEX>("api/Session/GetComplexById/" + idSession, null);
        }

        public async Task SetImageSession(int idSession, int idImage, String token)
        {
            Order order = new Order();
            order.id = idSession;
            order.order = idImage;
            await this.api.CallApiPost(order, "api/Session/SetImageSession", token);
        }

    }
}
