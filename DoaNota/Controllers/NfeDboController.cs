using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoaNota.Controllers
{
    public class NfeDboController : ApiController
    {
        [HttpGet]
        public double GetCustomers(string cfe, string total, int id)
        {
            using (SqlConnection conn = sql.OpenConnection())
            {
                double valorTotal = double.Parse(total.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
                // Cria um comando para atualizar um registro da tabela
                using (SqlCommand cmd = new SqlCommand(@"
                INSERT INTO 
                    [Doanfs].[dbo].[NOTA FISCAL] 
                        ([CFE], [TOTAL], [ID_ENTIDADE]) 
                    VALUES 
                        (@cfe, @total, @id)", conn))
                {
                    cmd.Parameters.AddWithValue("@cfe", cfe);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@id", id);
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Entidade inexistente!");
                    }
                }

                // Cria um comando para atualizar um registro da tabela
                using (SqlCommand cmd = new SqlCommand(@"
                UPDATE
                    [Doanfs].[dbo].[ENTIDADE] 
                        SET [TOTAL] = [TOTAL] + @novo
                    WHERE
                        ID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@novo", valorTotal * 0.2);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }

                // Cria um comando para atualizar um registro da tabela
                using (SqlCommand cmd = new SqlCommand(@"
                SELECT [TOTAL] FROM
                    [Doanfs].[dbo].[ENTIDADE]
                    WHERE
                        ID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    return (double)cmd.ExecuteScalar();
                }
            }
        }
    }
}
