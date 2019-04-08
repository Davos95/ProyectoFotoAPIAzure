
using ProyectoFotoCore.Data;
using ProyectoFotoCore.Models;
using ProyectoFotoCore.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        ApiConnect api;

        public RepositoryPartner( ApiConnect api)
        {
            this.api = api;
        }

        
        public async Task<List<WORKER>> GetPartners()
        {
            List<WORKER> participantes = await this.api.CallApi<List<WORKER>>("api/Partner", null);
            return participantes;
        }

        public async Task InsertPartner(String name, String contact, String urlContact)
        {
            WORKER w = new WORKER();
            w.Name = name;
            w.Contact = contact;
            w.UrlContact = urlContact;
            await this.api.CallApiPost(w, "api/Partner/Insert", null);

        }

        public async Task RemovePartner(int id)
        {
            await this.api.ApiDelete("api/Partner/Delete/" + id,null);
        }

        public async Task UpdatePartner(int id, String name, String contact, String urlContact)
        {
            WORKER w = new WORKER();
            w.Id = id;
            w.Name = name;
            w.Contact = contact;
            w.UrlContact = urlContact;
            await this.api.CallApiPost(w, "api/Partner/Modify", null);
        }



    }
}