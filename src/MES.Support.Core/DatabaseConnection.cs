using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace MES.Support.Core
{
    public class DatabaseConnection
    {
        private string connectionString =
            @"Server=localhost\SQLEXPRESS;
              Database=ProductionERP;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
