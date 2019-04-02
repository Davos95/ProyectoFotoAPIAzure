
using ProyectoFotoCore.Data;
using ProyectoFotoCore.Models;
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
        IPictureManagerContext context;
        public RepositorySesion(IPictureManagerContext context)
        {
            this.context = context;
        }

        public List<SESSION> GetSesions()
        {
            var sesion = this.context.GetSesions();
            return sesion.ToList();
        }

        public void InsertSesion(String name, String description, DateTime date, int comision)
        {
            this.context.InsertSesion(name, description, date, comision);
        }

        public void DeleteSesion(int id)
        {
            this.context.DeleteSesion(id);
        }

        public SESSION GetSESIONID(int id)
        {
            SESSION sesion = this.context.GetSESIONID(id);
            return sesion;
        }


        #region EDIT SESION
        public void AddPartnerWorkIntoSesion(int idSesion, int idPartner, int idWork)
        {
            this.context.AddPartnerWorkIntoSesion(idSesion, idPartner, idWork);
        }

        public List<Worker_Session_Complex> GetPartnerWorkBySesion(int idSesion)
        {
            return this.context.GetPartnerWorkBySesion(idSesion);
        }

        public void DeletePartnerWorkFromSesion(int idSesion, int idPartner, int idWork)
        {
            this.context.DeletePartnerWorkFromSesion(idSesion, idPartner, idWork);
        }

        public void ModifySesion(int idSesion, String name, String desciption, DateTime date, int idComision)
        {
            this.context.ModifySesion(idSesion, name, desciption, date, idComision);
        }

        public void SetImageSession(int idSession, int idImage)
        {
            this.context.SetImageSession(idSession, idImage);
        }

        public List<SESSION_COMPLEX> GetSessionsComplex()
        {
            return this.context.GetSessionsComplex();
        }

        public SESSION_COMPLEX GetSessionComplexById(int idSession)
        {
            return this.context.GetSessionComplexById(idSession);
        }

        #endregion
    }
}
