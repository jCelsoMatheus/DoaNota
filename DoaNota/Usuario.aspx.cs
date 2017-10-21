using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoaNota
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Sql.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT NOME, EMAIL, SENHA FROM USUARIO WHERE EMAIL = @email and SENHA = @senha ORDER BY Nome ASC", conn))
                {
                    // Esse valor poderia vir de qualquer outro lugar, como uma TextBox...
                    cmd.Parameters.AddWithValue("@email", txtDigiteEmail.Text);
                    cmd.Parameters.AddWithValue("@senha", txtDigiteSenha.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Obtém os registros, um por vez
                        if (reader.Read()) 
                        {
                            string email = reader.GetString(1);
                            string senha = reader.GetString(2);

                            Response.Redirect("Doacao.aspx");

                        }
                        else
                        {
                            lblAviso.Text = "E-mail ou Senha inválidos";

                        }
                    }
                }
            }
        }       


        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

    }
}