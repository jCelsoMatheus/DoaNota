using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DoaNota
{
    public static class Sql
    {
        public static SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection("Server=tcp:doanota.database.windows.net,1433;Database=doanota;User ID=waltermagni@terra.com.br;Password=Walter182;Encrypt=True;TrustServerCertificate=False;Connection Timeout=60;");

            conn.Open();

            return conn;
        }
    }
}