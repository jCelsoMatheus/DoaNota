using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoaNota
{
    public partial class cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            



        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text.Trim();
            if (nome.Length == 0)
            {
                lblErro.Text = "Nome inválido!";
                return;
            }

            string email = txtEmail.Text.Trim();
            int arroba, arroba2, ponto;

            arroba = email.IndexOf('@');
            arroba2 = email.LastIndexOf('@');
            ponto = email.LastIndexOf('.');

            if (arroba <= 0 || ponto <= (arroba + 1) || ponto == (email.Length - 1) || arroba2 != arroba)
            {
                lblErro.Text = "E-mail inválido!";
                return;
            }

            int TamanhoMaximoDaSenha = 15;
            string senha = txtSenha.Text.Trim();
            string confSenha = txtConfSenha.Text.Trim();
            if (string.IsNullOrEmpty(senha) || senha.Length > TamanhoMaximoDaSenha)
            {
                throw new Exception("Senha inválida");
            }

            if (senha != confSenha)
            {
                throw new Exception("Senha inválida");
            }

            using (SqlConnection conn = sql.OpenConnection() )
            {
               
                // Cria um comando para inserir um novo registro à tabela
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [doanota].[dbo].[USUARIO] ([NOME], [EMAIL], [SENHA])  OUTPUT INSERTED.Id VALUES (@nome, @email, @senha)", conn))
                {
                    // Esses valores poderiam vir de qualquer outro lugar, como uma TextBox...
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                    // Agora a variável id conterá o valor do campo Id do registro criado
                    int ID = (int)cmd.ExecuteScalar();

                    Response.Redirect("login.aspx");
                }
            }


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}
