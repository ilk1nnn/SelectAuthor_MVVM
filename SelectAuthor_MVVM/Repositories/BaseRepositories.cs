using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Repostories
{
    public abstract class RepostoryBase
    {
        private static string _connectionString = "Data Source=STHQ0127-03;Initial Catalog=Library;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}