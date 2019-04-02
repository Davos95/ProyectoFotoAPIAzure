
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore.Provider
{
    public enum Folders {
        Comision = 0, Session = 1
    }

    public class PathProv
    {

       public IHostingEnvironment environment;
        public PathProv(IHostingEnvironment environment)
        {
            this.environment = environment;
        }

        public String MapPath(Folders folder)
        {
            String path;
            
            String root = "images";
            String foldername = "";
            
            switch (folder)
            {
                case Folders.Comision: foldername = "comision"; break;
                case Folders.Session: foldername = "session"; break;
            }
       
            path = Path.Combine(this.environment.WebRootPath, root, foldername);
            
            return path;
        }

        public String MapPath(Folders folder, String SessionName)
        {
            String path;

            String root = "images";
            String foldername = "";

            switch (folder)
            {
                case Folders.Session: foldername = "session"; break;
            }
            
            path = Path.Combine(this.environment.WebRootPath, root, foldername, SessionName);
                
            return path;
        }

    }
}
