using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace DoaNota
{
    public static class Sql
    {
        public static SqlConnection OpenConnection()
        {

            string myConnStr = ConfigurationManager.ConnectionStrings["YourConnectionStringName"].ConnectionString;

            SqlConnection conn = new SqlConnection(myConnStr);

            conn.Open();

            return conn;
        }
    }
}