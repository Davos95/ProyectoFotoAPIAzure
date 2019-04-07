﻿using ApiProyectoFoto.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProyectoFoto.Repositories
{
    public interface IRepositoryComision
    {
        List<COMISION> GetCOMISIONS();
        void InsertComision(String name, String description, float price, String UriAzure);
        void DeleteComision(int id, String folder);
        void ModifyComision(int id, String name, String description, String folder, String image, float price, String UriAzure);
        void OrderComision(String[] order);
        COMISION GetComisionByID(int id);
    }
}
