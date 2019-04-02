
using ProyectoFotoCore.Data;
using ProyectoFotoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

#region PROCEDURES
/*

CREATE PROCEDURE MOSTRARPARTICIPANTES
AS
	SELECT * FROM WORKER;
GO

CREATE PROCEDURE ADDPARTICIPANTE
(@NAME NVARCHAR(30), @CONTACT NVARCHAR(30), @URLCONTACT NVARCHAR(255))
AS
	INSERT INTO WORKER VALUES (@NAME, @CONTACT, @URLCONTACT)
GO

CREATE PROCEDURE DELETEPARTICIPANTE
(@ID INT)
AS
	DELETE FROM WORKER WHERE ID = @ID
GO

CREATE PROCEDURE UPDATEPARTICIPANTE
(@ID INT, @NAME NVARCHAR(30), @CONTACT NVARCHAR(30), @URLCONTACT NVARCHAR(30))
AS
	UPDATE WORKER
	SET NAME = @NAME, CONTACT = @CONTACT, URLCONTACT = @URLCONTACT
	WHERE ID = @ID
GO





*/
#endregion

namespace ProyectoFotoCore.Repositories
{
    public class RepositoryPartner : IRepositoryPartner
    {
        IPictureManagerContext context;

        public RepositoryPartner(IPictureManagerContext context)
        {
            this.context = context;
        }
        
        public List<WORKER> GetPartners()
        {

            List<WORKER> participantes = this.context.GetPartners();
            return participantes;
        }

        public void InsertPartner(String name, String contact, String urlContact)
        {
            this.context.InsertPartner(name, contact, urlContact);
        }

        public void RemovePartner(int id)
        {
            this.context.RemovePartner(id);
        }

        public void UpdatePartner(int id, String name, String contact, String urlContact)
        {
            this.context.UpdatePartner(id, name, contact, urlContact);
        }



    }
}