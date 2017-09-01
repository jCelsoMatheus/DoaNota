using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoaNota
{
    public partial class deleteprod : System.Web.UI.Page
    {  
        [WebMethod(EnableSession = false)]

        public static string GetCustomers(int id)
        {
            using (SqlConnection conn = sql.OpenConnection())
            {
                // Cria um comando para atualizar um registro da tabela
                using (SqlCommand cmd = new SqlCommand(@"
                DELETE FROM 
                        [mybank].[dbo].[PRODUTO_PADARIA] 
                    WHERE 
                        ([id]=@id)", conn))
                {
      
                    cmd.Parameters.AddWithValue("@id", id);
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        return "1";
                    }
                    else
                    {
                        return "0";
                    }
                }
            }
        }
    }
}