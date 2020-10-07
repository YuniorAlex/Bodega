﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos.Repositories
{
     public abstract class Repository
    {
        private readonly string connectionString;
        public Repository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CapaPresentacion.Properties.Settings.BodegaBD"].ToString();
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
