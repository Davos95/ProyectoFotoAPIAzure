

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
 * 
CREATE PROCEDURE MOSTRARTRABAJOS
AS

    SELECT* FROM WORK;
GO

CREATE PROCEDURE ADDTRABAJO
(@NAME NVARCHAR(100))
AS
    INSERT INTO WORK VALUES(@NAME)
GO

CREATE PROCEDURE DELETETRABAJO
(@ID INT)
AS
    DELETE FROM WORK WHERE ID = @ID
GO

*/
#endregion

namespace ProyectoFotoCore.Repositories
{
    public class RepositoryWork : IRepositoryWork
    {
        ApiConnect api;

        public RepositoryWork(ApiConnect api) {
            this.api = api;
        }

        public async Task<List<WORK>> GetWORKs()
        {
            List<WORK> works = await this.api.CallApi<List<WORK>>("api/Work",null);
            return works;
        }

        public async Task InsertWork(String name)
        {
            WORK w = new WORK();
            w.Name = name;
            await this.api.CallApiPost(w, "api/Work/Insert", null);
        }

        public async Task DeleteWork(int id)
        {
            await this.api.ApiDelete("api/Work/Delete/" + id, null);
        }

    }
}
