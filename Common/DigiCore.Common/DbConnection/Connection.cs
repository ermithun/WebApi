
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace DigiCore.Common.DbConnection
{
    public class Connection
    {
        string connStr = string.Empty;
        public Connection()
        {
            connStr = GetConnectionString();
        }


        public SqlConnection GetConnection()
        {
            SqlConnection _conn = new SqlConnection(connStr);
            _conn.Open();
            return _conn;
        }



        private string connectionString;
        private IConfigurationRoot Configuration { get; set; }

        public int CommandTimeout
        {
            get
            {
                return 200;
            }
        }

        public string GetConnectionString()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                var configuration = new ConfigurationBuilder()
                     .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                Configuration = configuration.Build();
                connectionString = Configuration.GetConnectionString("DefaultConnection");
            }
            return connectionString;
        }
    }

}
