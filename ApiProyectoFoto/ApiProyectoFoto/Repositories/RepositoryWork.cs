using ApiProyectoFoto.Data;
using ApiProyectoFoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ApiProyectoFoto.Repositories
{
    public class RepositoryWork : IRepositoryWork
    {
        IPictureManagerContext context;

        public RepositoryWork(IPictureManagerContext context)
        {
            this.context = context;
        }

        public List<WORK> GetWORKs()
        {
            List<WORK> works = this.context.GetWORKs();
            return works;
        }

        public void InsertWork(String name)
        {
            this.context.InsertWork(name);
        }

        public void DeleteWork(int id)
        {
            this.context.DeleteWork(id);
        }

    }
}
