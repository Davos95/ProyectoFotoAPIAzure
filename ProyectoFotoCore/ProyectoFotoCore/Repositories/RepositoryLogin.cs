using ProyectoFotoCore.Data;
using ProyectoFotoCore.Models;
using ProyectoFotoCore.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


#region PROCEDURE
/*
CREATE PROCEDURE GETUSER
(@NICK NVARCHAR(25), @PWD NVARCHAR(25))
AS
    SELECT *

    FROM USERS

    WHERE NICK LIKE @NICK

    AND PWD LIKE @PWD;
GO
*/
#endregion

namespace ProyectoFotoCore.Repositories
{
    public class RepositoryLogin : IRepositoryLogin
    {
        ApiConnect api;
        public RepositoryLogin(ApiConnect api)
        {
            this.api = api;
        }

        public async Task<USER> GetUser(String token)
        {
            USER user = await this.api.CallApi<USER>("api/Auth/GetUSER", token);
            return user;
        }

        public async Task<String> GetToken(String nick, String pwd)
        {
            return await this.api.GetToken(nick, pwd);
        }

        private String createMD5Hash(String input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();            
        }
    }
}
