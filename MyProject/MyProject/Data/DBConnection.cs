using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data
{
    public class DBConnection
    {
        protected string _connString = null;
        protected SqlConnection _conn = null;
        protected SqlTransaction _trans = null;
        protected bool _disposed = false;

        public static string ConnectionString { get; set; }

        public void Connect()
        {
            _conn = new SqlConnection(_connString);
            _conn.Open();
        }

        public DBConnection()
        {
            _connString = ConnectionString;
        }

        public DBConnection(string databaseName)
        {
            var basePath = Directory.GetCurrentDirectory();
            var AppSetting = new ConfigurationBuilder()
               .SetBasePath(basePath)
               .AddJsonFile("appsettings.json")
               .Build();
            _connString = AppSetting.GetConnectionString(databaseName);
        }
    }
}
